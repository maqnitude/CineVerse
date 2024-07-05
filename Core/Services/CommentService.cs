using CineVerse.Core.Events;
using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CineVerse.Core.Services
{
    public class CommentService
    {
        private static CommentService? _instance;

        public static CommentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CommentService();
                }
                return _instance;
            }
        }

        private CommentService()
        {

        }

        public async Task<List<Comment>> GetRecentCommentsAsync(int count)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                return await unitOfWork.Comments.GetRecentCommentsAsync(count);
            }
        }

        public async Task<List<Comment>> GetCommentRepliesAsync(string commentId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var replies = await unitOfWork.Comments.GetCommentRepliesAsync(commentId);
                return replies.ToList();
            }
        }

        public async Task<CommentVote> GetCommentVoteAsync(string commentId, string userId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var vote = await unitOfWork.CommentVotes.GetCommentVoteByCommentIdUserIdAsync(commentId, userId);
                return vote;
            }
        }

        public async Task AddCommentReplyAsync(string parentCommentId, string userId, string content)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var parentComment = await unitOfWork.Comments.GetCommentByIdAsync(parentCommentId)
                    ?? throw new Exception("Parent comment not found");
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var comment = new Comment()
                {
                    Id = Guid.NewGuid().ToString(),
                    Content = content,
                    UserId = user.Id,
                    PostId = parentComment.PostId,
                    CreatedAt = DateTime.UtcNow,
                    ParentCommentId = parentComment.Id,
                };

                await unitOfWork.Comments.AddAsync(comment);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task AddOrUpdateCommentVoteAsync(string commentId, string userId, bool isUpvote)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var comment = await unitOfWork.Comments.GetCommentByIdAsync(commentId)
                    ?? throw new Exception("Comment not found");
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var vote = await unitOfWork.CommentVotes.GetCommentVoteByCommentIdUserIdAsync(commentId, userId);
                if (vote != null)
                {
                    if (vote.IsUpvote != isUpvote)
                    {
                        vote.IsUpvote = isUpvote;

                        unitOfWork.CommentVotes.Update(vote);

                        if (isUpvote)
                        {
                            comment.Upvotes++;
                            comment.Downvotes--;
                        }
                        else
                        {
                            comment.Upvotes--;
                            comment.Downvotes++;
                        }
                        comment.UpdatedAt = DateTime.UtcNow;

                        unitOfWork.Comments.Update(comment);

                        await unitOfWork.CompleteAsync();

                        EventManager.Instance.Publish(EventType.CommentVoteChanged, this,
                            new CommentVoteEventArgs(commentId, userId, isUpvote, comment.Upvotes, comment.Downvotes));
                    }
                }
                else
                {
                    var newVote = new CommentVote()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserId = user.Id,
                        CommentId = comment.Id,
                        IsUpvote = isUpvote,
                        CreatedAt = DateTime.UtcNow
                    };

                    await unitOfWork.CommentVotes.AddAsync(newVote);

                    if (isUpvote)
                    {
                        comment.Upvotes++;
                    }
                    else
                    {
                        comment.Downvotes++;
                    }

                    unitOfWork.Comments.Update(comment);

                    await unitOfWork.CompleteAsync();

                    EventManager.Instance.Publish(EventType.CommentVoteAdded, this,
                        new CommentVoteEventArgs(commentId, userId, isUpvote, comment.Upvotes, comment.Downvotes));
                }
            }
        }

        public async Task RemoveCommentVoteAsync(string commentId, string userId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var comment = await unitOfWork.Comments.GetCommentByIdAsync(commentId)
                    ?? throw new Exception("Comment not found");
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var vote = await unitOfWork.CommentVotes.GetCommentVoteByCommentIdUserIdAsync(comment.Id, user.Id);
                if (vote != null)
                {
                    unitOfWork.CommentVotes.Delete(vote);

                    if (vote.IsUpvote)
                    {
                        comment.Upvotes--;
                    }
                    else
                    {
                        comment.Downvotes--;
                    }

                    unitOfWork.Comments.Update(comment);

                    await unitOfWork.CompleteAsync();

                    EventManager.Instance.Publish(EventType.CommentVoteAdded, this,
                        new CommentVoteEventArgs(commentId, userId, vote.IsUpvote, comment.Upvotes, comment.Downvotes));
                }
            }
        }
    }
}
