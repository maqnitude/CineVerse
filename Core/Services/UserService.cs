using CineVerse.Core.Events;
using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Services
{
    public class UserService
    {
        private static UserService _instance;

        public static UserService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserService();
                }
                return _instance;
            }
        }

        private UserService() { }

        public async Task UpdateUser(string userId, User newUser)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByIdAsync(userId);
                user.Username = newUser.Username;
                user.AvatarPath = newUser.AvatarPath;

                unitOfWork.Users.Update(user);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task RateMovieAsync(string userId, int movieId, double rating)
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
                    existingReview.UpdatedAt = DateTime.UtcNow;

                    unitOfWork.Reviews.Update(existingReview);
                    await unitOfWork.CompleteAsync();
                }
                else
                {
                    var review = new Review()
                    {
                        Id = Guid.NewGuid().ToString(),
                        UserId = user.Id,
                        MovieId = movie.Id,
                        Rating = rating,
                        Content = null,
                        CreatedAt = DateTime.UtcNow
                    };

                    await unitOfWork.Reviews.AddAsync(review);
                    await unitOfWork.CompleteAsync();
                }

                EventManager.Instance.Publish(EventType.UserMovieRated, this, EventArgs.Empty);
            }
        }
    }
}
