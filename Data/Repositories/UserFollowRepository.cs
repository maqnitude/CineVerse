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
    public class UserFollowRepository : Repository<UserFollow>, IUserFollowRepository
    {
        public UserFollowRepository(AppDbContext context) : base(context) { }

        public async Task<UserFollow> GetFollowAsync(string followerId, string followeeId)
        {
            return await _context.Set<UserFollow>()
                .FirstOrDefaultAsync(uf => uf.FollowerId == followerId && uf.FolloweeId == followeeId);
        }

        public async Task<List<User>> GetFolloweesAsync(string userId)
        {
            return await _context.Set<UserFollow>()
                .Where(uf => uf.FollowerId == userId)
                .Select(uf => uf.Followee)
                .ToListAsync();
        }

        public async Task<List<User>> GetFollowersAsync(string userId)
        {
            return await _context.Set<UserFollow>()
                .Where(uf => uf.FolloweeId == userId)
                .Select(uf => uf.Follower)
                .ToListAsync();
        }

        public async Task<bool> IsFollowingAsync(string followerId, string followeeId)
        {
            return await _context.Set<UserFollow>()
                .AnyAsync(uf => uf.FollowerId == followerId && uf.FolloweeId == followeeId);
        }
    }
}
