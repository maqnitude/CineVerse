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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(AppDbContext context) : base(context) { }

        public async Task<Comment> GetCommentByIdAsync(string commentId)
        {
            return await _context.Set<Comment>().FindAsync(commentId);
        }

        public async Task<IEnumerable<Comment>> GetCommentRepliesAsync(string commentId)
        {
            return await _context.Set<Comment>()
                .Where(c => c.Id == commentId)
                .Include(c => c.Replies)
                    .ThenInclude(r => r.User)
                .SelectMany(c => c.Replies)
                .Where(r => r.ParentCommentId != null)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetRecentCommentsAsync(int count)
        {
            return await _context.Comments
                .Include(c => c.User)
                .Include(c => c.Post)
                .OrderByDescending(c => c.CreatedAt)
                .Take(count)
                .ToListAsync();
        }
    }
}
