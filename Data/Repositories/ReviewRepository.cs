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
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Review>> GetReviewsByMovieIdAsync(int movieId)
        {
            return await _context.Set<Review>()
                .Where(r => r.MovieId == movieId)
                .Include(r => r.User)
                .ToListAsync();
        }

        public async Task<Review> GetReviewByUserIdMovieIdAsync(string userId, int movieId)
        {
            return await _context.Set<Review>()
                .Where(r => r.UserId == userId && r.MovieId == movieId)
                .FirstOrDefaultAsync();
        }
    }
}
