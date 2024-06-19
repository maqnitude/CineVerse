using CineVerse.Core.Interfaces;
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
        private readonly IUnitOfWork _unitOfWork;

        public MovieBrowsingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> IsLastPage(int pageNumber, int pageSize)
        {
            int moviesCount = await _unitOfWork.Movies.CountMoviesAsync();
            return pageNumber * pageSize >= moviesCount;
        }

        public async Task<List<Movie>> GetMoviesInPageAsync(int pageNumber, int pageSize)
        {
            var movies = await _unitOfWork.Movies.GetMoviesAsync(pageNumber, pageSize);
            return movies.ToList();
        }
    }
}
