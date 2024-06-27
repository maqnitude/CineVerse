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

        public async Task<IEnumerable<Movie>> GetMoviesAsync(int pageNumber, int pageSize)
        {
            return await _context.Set<Movie>().Skip((pageNumber - 1) *  pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<List<Person>> GetTopCastsByMovieIdAsync(int movieId, int n)
        {
            return await _context.Set<Credit>()
                .Where(c => c.MovieId == movieId && c.Type == "cast")
                .Include(c => c.Person)
                .OrderBy(c => c.Order ?? int.MaxValue)
                .Select(c => c.Person)
                .Distinct()
                .Take(n)
                .ToListAsync();
        }

        public async Task<List<Person>> GetTopCrewsByMovieIdAsync(int movieId, int n)
        {
            return await _context.Set<Credit>()
                .Where(c => c.MovieId == movieId && c.Type == "crew")
                .Include(c => c.Person)
                .Select(c => c.Person)
                .Distinct()
                .Take(n)
                .ToListAsync();
        }
    }
}
