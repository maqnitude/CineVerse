using CineVerse.Core.Interfaces;
using CineVerse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext context) : base(context) { }

        public async Task<int> CountMoviesAsync()
        {
            return await _context.Set<Movie>().CountAsync();
        }

        public async Task<Movie> GetMovieByTMDBIdAsync(int tmdbId)
        {
            return await _context.Set<Movie>().FirstOrDefaultAsync(m => m.Id == tmdbId);
        }

        public async Task<IEnumerable<Movie>> GetMoviesByPageAsync(int pageNumber, int pageSize,
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null)
        {
            IQueryable<Movie> query = _context.Set<Movie>();

            // Filter by something
            if (!string.IsNullOrWhiteSpace(filterBy))
            {
                switch (filterBy.ToLower())
                {
                    case "decade":
                        if (!string.IsNullOrWhiteSpace(filterValue))
                        {
                            switch (filterValue.ToLower())
                            {
                                case "all":
                                    break;
                                case "upcoming":
                                    query = query.Where(m => m.ReleaseDate == null);
                                    break;
                                default:
                                    int startYear = int.Parse(filterValue.Substring(0, 4));
                                    int endYear = startYear + 9;
                                    query = query
                                        .Where(m => m.ReleaseDate != null && m.ReleaseDate.Value.Year >= startYear && m.ReleaseDate.Value.Year <= endYear);
                                    break;
                            }
                        }
                        break;
                }
            }

            // Sort by something
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy.ToLower())
                {
                    case "rating":
                        if (string.IsNullOrWhiteSpace(sortValue)) { break; }
                        switch (sortValue.ToLower())
                        {
                            case "highest":
                                query = query.OrderBy(m => m.VoteAverage);
                                break;
                            case "lowest":
                                query = query.OrderByDescending(m => m.VoteAverage);
                                break;
                        }
                        break;
                }
            }

            return await query.Skip((pageNumber - 1) *  pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> SearchMoviesAsync(string searchTerm, int maxItems = 100)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return Enumerable.Empty<Movie>();
            }

            IQueryable<Movie> query = _context.Set<Movie>();

            searchTerm = searchTerm.ToLower();
            query = query.Where(m => m.Title.ToLower().Contains(searchTerm)
                || m.Credits.Any(c => c.Person.Name.ToLower() == searchTerm && c.Job == "Director"));

            return await query.Take(maxItems).ToListAsync();
        }
    }
}
