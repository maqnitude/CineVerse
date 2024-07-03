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
        Task<IEnumerable<Movie>> GetMoviesByPageAsync(int pageNumber, int pageSize,
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null);
        Task<int> CountMoviesAsync(
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null);
        Task<List<Person>> GetTopCastsByMovieIdAsync(int movieId, int n);
        Task<List<Person>> GetTopCrewsByMovieIdAsync(int movieId, int n);
        Task<Person> GetDirectorByMovieIdAsync(int movieId);
        Task<List<Person>> GetDirectorsByMovieIdAsync(int movieId);
        Task<IEnumerable<Movie>> SearchMoviesAsync(string searchTerm, int maxItems = 100);
    }
}
