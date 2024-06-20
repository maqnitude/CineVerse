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
    public class MovieBrowsingService
    {
        private static MovieBrowsingService? _instance;

        public static MovieBrowsingService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieBrowsingService();
                }
                return _instance;
            }
        }

        private MovieBrowsingService()
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

        public async Task<List<Movie>> GetMoviesInPageAsync(int pageNumber, int pageSize)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movies = await unitOfWork.Movies.GetMoviesAsync(pageNumber, pageSize);
                return movies.ToList();
            }
        }
    }
}
