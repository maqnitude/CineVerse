using CineVerse.Core.Interfaces;
using CineVerse.Data;
using CineVerse.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        public async Task<bool> IsLastPage(int pageNumber, int pageSize,
            string? filterBy = null, string? filterValue = null,
            string? sortBy = null, string? sortValue = null)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                int moviesCount = await unitOfWork.Movies.CountMoviesAsync(filterBy, filterValue, sortBy, sortValue);
                return pageNumber * pageSize >= moviesCount;
            }
        }

        public async Task<bool> IsMovieInListAsync(string listId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var listMovie = await unitOfWork.ListMovies.GetAsync(listId, movieId);
                return listMovie != null;
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

                var existingReview = await unitOfWork.Reviews.GetReviewByUserIdMovieIdAsync(userId, movieId);

                if (existingReview != null)
                {
                    existingReview.Rating = rating;
                    existingReview.Content = content;
                    existingReview.UpdatedAt = DateTime.UtcNow;

                    unitOfWork.Reviews.Update(existingReview);
                    await unitOfWork.CompleteAsync();
                }
                else
                {
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

        public async Task<Person> GetMovieDirector(int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var director = await unitOfWork.Movies.GetDirectorByMovieIdAsync(movieId);
                return director;
            }
        }

        public async Task<List<Person>> GetMovieDirectors(int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var directors = await unitOfWork.Movies.GetDirectorsByMovieIdAsync(movieId);
                return directors;
            }
        }

        public async Task<List<Movie>> SearchMoviesAsync(string searchTerm)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movies = await unitOfWork.Movies.SearchMoviesAsync(searchTerm);
                return movies.ToList();
            }
        }
    }
}
