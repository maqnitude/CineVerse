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
    public class PostVoteRepository : Repository<PostVote>, IPostVoteRepository
    {
        public PostVoteRepository(AppDbContext context) : base(context) { }

        public async Task<PostVote> GetPostVoteByPostIdUserIdAsync(string postId, string userId)
        {
            return await _context.Set<PostVote>()
                .Where(v => v.PostId == postId && v.UserId == userId)
                .FirstOrDefaultAsync();
        }
    }
}
