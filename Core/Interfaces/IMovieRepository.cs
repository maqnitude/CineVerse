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
        Task<IEnumerable<Movie>> FindMoviesByTitleAsync(string title);
        Task<IEnumerable<Movie>> GetMoviesAsync(int pageNumber,  int pageSize);
        Task<int> CountMoviesAsync();
    }

}
