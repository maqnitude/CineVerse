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
    public class ListMovieRepository : Repository<ListMovie>, IListMovieRepository
    {
        public ListMovieRepository(AppDbContext context) : base(context) { }

        public async Task<ListMovie> GetAsync(string listId, int movieId)
        {
            return await _context.Set<ListMovie>().FirstOrDefaultAsync(lm => lm.ListId == listId && lm.MovieId == movieId);
        }
    }
}
