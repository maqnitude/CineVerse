using CineVerse.Core.Events;
using CineVerse.Data;
using CineVerse.Data.Entities;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Services
{
    public class PostService
    {
        private static PostService? _instance;

        public static PostService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PostService();
                }
                return _instance;
            }
        }

        private PostService()
        {
            
        }

        public async Task<Post> GetPostByIdAsync(string postId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var post = await unitOfWork.Posts.GetPostByIdAsync(postId);
                return post;
            }
        }

        public async Task<List<Post>> GetPostsAsync(int page, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var posts = await unitOfWork.Posts.GetPostsByPageAsync(page, pageSize);
                return posts.ToList();
            }
        }

        public async Task<List<Comment>> GetPostRepliesAsync(string postId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var replies = await unitOfWork.Posts.GetPostRepliesAsync(postId);
                return replies.ToList();
            }
        }

        public async Task<PostVote> GetPostVoteAsync(string postId, string userId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var vote = await unitOfWork.PostVotes.GetPostVoteByPostIdUserIdAsync(postId, userId);
                return vote;
            }
        }

        public async Task<int> CountPostRepliesAsync(string postId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var count = await unitOfWork.Posts.CountPostRepliesAsync(postId);
                return count;
            }
        }

        public async Task AddPostAsync(string userId, string title, string content)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var post = new Post
                {
                    Id = Guid.NewGuid().ToString(),
                    Title = title,
                    Content = content,
                    UserId = user.Id,
                    CreatedAt = DateTime.UtcNow,
                };

                await unitOfWork.Posts.AddAsync(post);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task AddPostReplyAsync(string postId, string userId, string content)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var post = await unitOfWork.Posts.GetPostByIdAsync(postId)
                    ?? throw new Exception("Post not found");
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var comment = new Comment()
                {
                    Id = Guid.NewGuid().ToString(),
                    Content = content,
                    UserId = user.Id,
                    PostId = post.Id,
                    CreatedAt = DateTime.UtcNow,
                    ParentCommentId = null,
                };

                await unitOfWork.Comments.AddAsync(comment);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task AddOrUpdatePostVoteAsync(string postId, string userId, bool isUpvote)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var post = await unitOfWork.Posts.GetPostByIdAsync(postId)
                    ?? throw new Exception("Post not found");
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var vote = await unitOfWork.PostVotes.GetPostVoteByPostIdUserIdAsync(postId, userId);
                if (vote != null)
                {
                    if (vote.IsUpvote != isUpvote)
                    {
                        vote.IsUpvote = isUpvote;

                        unitOfWork.PostVotes.Update(vote);

                        if (isUpvote)
                        {
                            post.Upvotes++;
                            post.Downvotes--;
                        }
                        else
                        {
                            post.Upvotes--;
                            post.Downvotes++;
                        }
                        post.UpdatedAt = DateTime.UtcNow;

                        unitOfWork.Posts.Update(post);

                        await unitOfWork.CompleteAsync();

                        EventManager.Instance.Publish(EventType.PostVoteChanged, this,
                            new PostVoteEventArgs(postId, userId, isUpvote, post.Upvotes, post.Downvotes));
                    }
                }
                else
                {
                    var newVote = new PostVote()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserId = user.Id,
                        PostId = post.Id,
                        IsUpvote = isUpvote,
                        CreatedAt = DateTime.UtcNow
                    };

                    await unitOfWork.PostVotes.AddAsync(newVote);

                    if (isUpvote)
                    {
                        post.Upvotes++;
                    }
                    else
                    {
                        post.Downvotes++;
                    }

                    unitOfWork.Posts.Update(post);

                    await unitOfWork.CompleteAsync();

                    EventManager.Instance.Publish(EventType.PostVoteAdded, this,
                        new PostVoteEventArgs(postId, userId, isUpvote, post.Upvotes, post.Downvotes));
                }
            }
        }

        public async Task RemovePostVoteAsync(string postId, string userId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var post = await unitOfWork.Posts.GetPostByIdAsync(postId)
                    ?? throw new Exception("Post not found");
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");

                var vote = await unitOfWork.PostVotes.GetPostVoteByPostIdUserIdAsync(post.Id, user.Id);
                if (vote != null)
                {
                    unitOfWork.PostVotes.Delete(vote);

                    if (vote.IsUpvote)
                    {
                        post.Upvotes--;
                    }
                    else
                    {
                        post.Downvotes--;
                    }

                    unitOfWork.Posts.Update(post);

                    await unitOfWork.CompleteAsync();

                    EventManager.Instance.Publish(EventType.PostVoteAdded, this,
                        new PostVoteEventArgs(postId, userId, vote.IsUpvote, post.Upvotes, post.Downvotes));
                }
            }
        }
    }
}
