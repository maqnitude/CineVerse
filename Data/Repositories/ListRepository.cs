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

        public async Task<List> GetListByIdAsync(string listId, bool includeUser = false, bool includeMovies = false)
        {
            IQueryable<List> query = _context.Set<List>()
                .Where(l => l.Id == listId);

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

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<List>> GetListsByTypeAsync(ListType listType, bool includeUser = false, bool includeMovies = false,
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null)
        {
            IQueryable<List> query = _context.Set<List>()
                .Where(l => l.Type == listType);

            if (!string.IsNullOrEmpty(filterBy))
            {
                // filter
            }

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy.ToLower())
                {
                    case "date":
                        if (string.IsNullOrEmpty(sortValue)) { break ; }
                        switch (sortValue.ToLower())
                        {
                            case "newest":
                                query = query.OrderBy(l => l.CreatedAt);
                                break;
                            case "oldest":
                                query = query.OrderByDescending(l => l.CreatedAt);
                                break;
                        }
                        break;
                }
            }

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

        public async Task<IEnumerable<List>> GetListsByUserIdAsync(string userId, bool includeUser = false, bool includeMovies = false,
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null)
        {
            IQueryable<List> query = _context.Set<List>()
                .Where(l => l.UserId == userId);

            if (!string.IsNullOrEmpty(filterBy))
            {
                // filter
            }

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy.ToLower())
                {
                    case "date":
                        if (string.IsNullOrEmpty(sortValue)) { break ; }
                        switch (sortValue.ToLower())
                        {
                            case "newest":
                                query = query.OrderBy(l => l.CreatedAt);
                                break;
                            case "oldest":
                                query = query.OrderByDescending(l => l.CreatedAt);
                                break;
                        }
                        break;
                }
            }

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
