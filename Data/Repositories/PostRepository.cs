using CineVerse.Core.Interfaces;
using CineVerse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context) { }

        public async Task<Post> GetPostByIdAsync(string postId)
        {
            return await _context.Set<Post>()
                .Where(p => p.Id == postId)
                .Include(p => p.User)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Post>> GetPostsByPageAsync(int page, int pageSize)
        {
            IQueryable<Post> query = _context.Set<Post>()
                .Include(p => p.User);

            return await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Comment>> GetPostRepliesAsync(string postId)
        {
            return await _context.Set<Post>()
                .Where(p => p.Id == postId)
                .Include(p => p.Replies)
                    .ThenInclude(c => c.User)
                .SelectMany(p => p.Replies)
                .Where(r => r.ParentCommentId == null) // null means it's a reply to a post
                .ToListAsync();
        }

        public async Task<int> CountPostRepliesAsync(string postId)
        {
            return await _context.Set<Post>()
                .Where(p => p.Id == postId)
                .Include(p => p.Replies)
                .SelectMany(p => p.Replies)
                .CountAsync();
        }
    }
}
