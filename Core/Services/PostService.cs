using CineVerse.Core.Events;
using CineVerse.Data;
using CineVerse.Data.Entities;
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
    }
}
