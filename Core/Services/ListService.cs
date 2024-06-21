using CineVerse.Core.Interfaces;
using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<List>> GetUserListsAsync(string userId, bool includeUser = false, bool includeMovies = false)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var lists = await unitOfWork.Lists.GetListsByUserIdAsync(userId, includeUser, includeMovies);
                return lists.ToList();
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

        public async Task AddMovieToLists(IEnumerable<string> listIds, int movieId)
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
            }
        }
    }
}
