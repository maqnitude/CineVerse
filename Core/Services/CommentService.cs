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

        public async Task<List<Comment>> GetCommentRepliesAsync(string commentId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var replies = await unitOfWork.Comments.GetCommentRepliesAsync(commentId);
                return replies.ToList();
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
    }
}
