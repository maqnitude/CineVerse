using CineVerse.Core.Interfaces;
using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Services
{
    public class MovieService
    {
        private static MovieService? _instance;

        public static MovieService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieService();
                }
                return _instance;
            }
        }

        private MovieService()
        {

        }

        public async Task<bool> IsLastPage(int pageNumber, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                int moviesCount = await unitOfWork.Movies.CountMoviesAsync();
                return pageNumber * pageSize >= moviesCount;
            }
        }

        public async Task<List<Movie>> GetMoviesAsync(int pageNumber, int pageSize,
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movies = await unitOfWork.Movies.GetMoviesByPageAsync(pageNumber, pageSize, filterBy, filterValue, sortBy, sortValue);
                return movies.ToList();
            }
        }

        public async Task<List<Movie>> GetMoviesByDecadeAsync(int pageNumber, int pageSize, string? decade)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movies = await unitOfWork.Movies.GetMoviesByPageAsync(pageNumber, pageSize, "decade", decade);
                return movies.ToList();
            }
        }

        public async Task AddMovieReviewAsync(string userId, int movieId, double rating, string? content)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");
                var movie = await unitOfWork.Movies.GetMovieByTMDBIdAsync(movieId)
                    ?? throw new Exception("Movie not found");

                var review = new Review()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserId = userId,
                    MovieId = movie.Id,
                    Rating = rating,
                    Content = content,
                    CreatedAt = DateTime.UtcNow
                };

                await unitOfWork.Reviews.AddAsync(review);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task<List<Person>> GetTopCastsByMovieIdAsync(int movieId, int n=10)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var casts = await unitOfWork.Movies.GetTopCastsByMovieIdAsync(movieId, n);
                return casts;
            }
        }
        
        public async Task<List<Person>> GetTopCrewsByMovieIdAsync(int movieId, int n = 10)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var crews = await unitOfWork.Movies.GetTopCrewsByMovieIdAsync(movieId, n);
                return crews;
            }
        }
    }
}
