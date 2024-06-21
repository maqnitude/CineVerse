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
    public class ListRepository : Repository<List>, IListRepository
    {
        public ListRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<List>> GetListsByUserIdAsync(string userId, bool includeUser = false, bool includeMovies = false)
        {
            IQueryable<List> query = _context.Set<List>()
                .Where(l => l.UserId == userId);

            if (includeUser)
            {
                query = query.Include(l => l.User);
            }

            if (includeMovies)
            {
                query = query.Include(l => l.Movies);
            }

            return await query.ToListAsync();
        }
    }
}
