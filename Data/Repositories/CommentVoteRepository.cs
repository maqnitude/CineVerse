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
    public class CommentVoteRepository : Repository<CommentVote>, ICommentVoteRepository
    {
        public CommentVoteRepository(AppDbContext context) : base(context) { }

        public async Task<CommentVote> GetCommentVoteByCommentIdUserIdAsync(string commentId, string userId)
        {
            return await _context.Set<CommentVote>()
                .Where(v => v.CommentId == commentId && v.UserId == userId)
                .FirstOrDefaultAsync();
        }
    }
}
