using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        Task<Movie> GetMovieByTMDBIdAsync(int tmdbId);
        Task<IEnumerable<Movie>> GetMoviesAsync(int pageNumber,  int pageSize);
        Task<int> CountMoviesAsync();
    }

}
