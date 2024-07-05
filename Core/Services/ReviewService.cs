using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Services
{
    public class ReviewService
    {
        private static ReviewService? _instance;

        public static ReviewService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReviewService();
                }
                return _instance;
            }
        } 

        private ReviewService()
        {

        }

        public async Task<List<Review>> GetReviewsAsync(int max = 100, bool includeUser = true, bool includeMovie = true)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var reviews = await unitOfWork.Reviews.GetReviewsAsync(max, includeUser, includeMovie);
                return reviews.ToList();
            }
        }

        public async Task<List<Review>> GetMovieReviewsAsync(int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var reviews = await unitOfWork.Reviews.GetReviewsByMovieIdAsync(movieId, includeUser: true);
                return reviews.ToList();
            }
        }

        public async Task<double> GetUserMovieRatingAsync(string userId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var review = await unitOfWork.Reviews.GetReviewByUserIdMovieIdAsync(userId, movieId);
                if (review != null)
                {
                    return review.Rating;
                }
                return 0.0;
            }
        }

        public async Task<int> CountMovieReviewsAsync(int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var reviews = await unitOfWork.Reviews.GetReviewsByMovieIdAsync(movieId);
                return reviews.Count();
            }
        }
    }
}
