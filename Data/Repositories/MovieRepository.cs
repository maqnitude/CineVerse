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

        public async Task<IEnumerable<Movie>> FindMoviesByTitleAsync(string title)
        {
            return await _context.Set<Movie>().Where(m => m.Title.Contains(title)).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetMoviesAsync(int pageNumber, int pageSize)
        {
            return await _context.Set<Movie>().Skip((pageNumber - 1) *  pageSize).Take(pageSize).ToListAsync();
        }
    }
}
