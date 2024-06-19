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

        public async Task<IEnumerable<Movie>> FindMoviesByTitleAsync(string title)
        {
            return await _context.Set<Movie>().Where(m => m.Title.Contains(title)).ToListAsync();
        }
    }
}
