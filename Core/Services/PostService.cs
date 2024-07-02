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
    }
}
