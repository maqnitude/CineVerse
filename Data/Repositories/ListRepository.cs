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

        //public async Task<List> GetWatchlistByUserIdAsync(string userId)
        //{

        //}

        public async Task<IEnumerable<List>> GetListsAsync(ListType listType, bool includeUser = false, bool includeMovies = false)
        {
            IQueryable<List> query = _context.Set<List>()
                .Where(l => l.Type == listType);

            if (includeUser)
            {
                query = query.Include(l => l.User);
            }

            if (includeMovies)
            {
                query = query
                    .Include(l => l.Movies) // this is just the ListMovie collection
                        .ThenInclude(lm => lm.Movie); // include actual movies
            }

            return await query.ToListAsync();
        }

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
                query = query
                    .Include(l => l.Movies) // this is just the ListMovie collection
                        .ThenInclude(lm => lm.Movie); // include actual movies
            }

            return await query.ToListAsync();
        }

        public async Task<List<Movie>> GetMoviesByListIdAsync(string listId)
        {
            var list = await _context.Set<List>()
                .Where(l => l.Id == listId)
                .Include(l => l.Movies)
                    .ThenInclude(lm => lm.Movie)
                .FirstOrDefaultAsync();

            if (list != null)
            {
                return list.Movies.Select(lm => lm.Movie).ToList();
            }
            
            return new List<Movie>();
        }
    }
}
