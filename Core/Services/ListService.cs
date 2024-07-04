using CineVerse.Core.Events;
using CineVerse.Core.Interfaces;
using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CineVerse.Core.Services
{
    public class ListService
    {
        private static ListService _instance;

        public static ListService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListService();
                }
                return _instance;
            }
        }

        private ListService()
        {
        }

        public async Task<List<List>> GetListsAsync(ListType listType, bool includeUser = false, bool includeMovies = false)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var lists = await unitOfWork.Lists.GetListsByTypeAsync(listType, includeUser, includeMovies);
                return lists.ToList();
            }
        }

        public async Task<List<List>> GetUserListsAsync(string userId, bool includeUser = false, bool includeMovies = false)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var lists = await unitOfWork.Lists.GetListsByUserIdAsync(userId, includeUser, includeMovies);
                return lists.ToList();
            }
        }

        public async Task<List> GetUserWatchlistAsync(string userId, bool includeUser = false, bool includeMovies = false)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");
                var watchlist = await unitOfWork.Lists.GetListByIdAsync(user.WatchlistId, includeUser, includeMovies)
                    ?? throw new Exception("Watchlist not found");

                return watchlist;
            }
        }

        public async Task<List> GetUserLikedListAsync(string userId, bool includeUser = false, bool includeMovies = false)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");
                var likedList = await unitOfWork.Lists.GetListByIdAsync(user.LikedListId, includeUser, includeMovies)
                    ?? throw new Exception("Liked list not found");

                return likedList;
            }
        }

        public async Task<List> GetUserWatchedListAsync(string userId, bool includeUser = false, bool includeMovies = false)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var user = await unitOfWork.Users.GetUserByIdAsync(userId)
                    ?? throw new Exception("User not found");
                var watchedList = await unitOfWork.Lists.GetListByIdAsync(user.WatchedListId, includeUser, includeMovies)
                    ?? throw new Exception("Watched list not found");

                return watchedList;
            }
        }

        public async Task<List<Movie>> GetMoviesFromListAsync(string listId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movies = await unitOfWork.Lists.GetMoviesByListIdAsync(listId);
                return movies;
            }
        }

        public async Task<int> CountUserListsAsync(string userId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var lists = await unitOfWork.Lists.GetListsByUserIdAsync(userId);
                return lists.Count() - 3; // exclude the 3 default lists
            }
        }

        public async Task AddListAsync(string userId, string name, ListType listType, string? description)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var list = new List()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = name,
                    Overview = description,
                    Type = listType,
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow
                };

                await unitOfWork.Lists.AddAsync(list);
                await unitOfWork.CompleteAsync();
            }
        }

        public async Task AddMovieToWatchlistAsync(string watchlistId, string watchedListId, string likedListId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                await AddMovieToListsAsync([watchlistId], movieId);
                await RemoveMovieFromListsAsync([watchedListId, likedListId], movieId);

                EventManager.Instance.Publish(EventType.WatchlistMovieAdded, this, EventArgs.Empty);
            }
        }

        public async Task AddMovieToWatchedListAsync(string watchedListId, string watchlistId, string likedListId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                await AddMovieToListsAsync([watchedListId], movieId);
                await RemoveMovieFromListsAsync([watchlistId], movieId);

                EventManager.Instance.Publish(EventType.WatchedListMovieAdded, this, EventArgs.Empty);
            }
        }

        public async Task AddMovieToLikedListAsync(string likedListId, string watchlistId, string watchedListId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                await AddMovieToListsAsync([likedListId, watchedListId], movieId);
                await RemoveMovieFromListsAsync([watchlistId], movieId);

                EventManager.Instance.Publish(EventType.LikedListMovieAdded, this, EventArgs.Empty);
            }
        }

        public async Task AddMovieToListsAsync(List<string> listIds, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movie = await unitOfWork.Movies.GetMovieByTMDBIdAsync(movieId);
                if (movie == null)
                {
                    throw new Exception("Movie not found");
                }

                foreach (var listId in listIds)
                {
                    var list = await unitOfWork.Lists.GetByIdAsync(listId);
                    if (list == null)
                    {
                        throw new Exception($"List with {listId} not found");
                    }

                    var existingListMovie = await unitOfWork.ListMovies.GetAsync(listId, movieId);
                    if (existingListMovie != null)
                    {
                        continue;
                    }

                    var listMovie = new ListMovie()
                    {
                        ListId = listId,
                        MovieId = movieId,
                        AddedDate = DateTime.UtcNow
                    };

                    await unitOfWork.ListMovies.AddAsync(listMovie);
                }

                await unitOfWork.CompleteAsync();

                EventManager.Instance.Publish(EventType.ListMovieAdded, this,
                    new ListMovieEventArgs(listIds, movieId));
            }
        }

        public async Task RemoveMovieFromWatchlistAsync(string watchlistId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                await RemoveMovieFromListsAsync([watchlistId], movieId);

                EventManager.Instance.Publish(EventType.WatchlistMovieRemoved, this, EventArgs.Empty);
            }
        }

        public async Task RemoveMovieFromWatchedListAsync(string watchedListId, string likedListId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                await RemoveMovieFromListsAsync([watchedListId, likedListId], movieId);

                EventManager.Instance.Publish(EventType.WatchedListMovieRemoved, this, EventArgs.Empty);
            }
        }

        public async Task RemoveMovieFromLikedListAsync(string likedListId, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                await RemoveMovieFromListsAsync([likedListId], movieId);

                EventManager.Instance.Publish(EventType.LikedListMovieRemoved, this, EventArgs.Empty);
            }
        }

        public async Task RemoveMovieFromListsAsync(List<string> listIds, int movieId)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movie = await unitOfWork.Movies.GetMovieByTMDBIdAsync(movieId);
                if (movie == null)
                {
                    throw new Exception("Movie not found");
                }

                foreach (var listId in listIds)
                {
                    var list = await unitOfWork.Lists.GetByIdAsync(listId);
                    if (list == null)
                    {
                        throw new Exception($"List with {listId} not found");
                    }

                    var existingListMovie = await unitOfWork.ListMovies.GetAsync(listId, movieId);
                    if (existingListMovie == null)
                    {
                        continue;
                    }

                    unitOfWork.ListMovies.Delete(existingListMovie);
                }

                await unitOfWork.CompleteAsync();

                EventManager.Instance.Publish(EventType.ListMovieRemoved, this,
                    new ListMovieEventArgs(listIds, movieId));
            }
        }
    }
}
