using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IListRepository : IRepository<List>
    {
        Task<List> GetListByIdAsync(string listId, bool includeUser = false, bool includeMovies = false);
        Task<IEnumerable<List>> GetListsByTypeAsync(ListType listType, bool includeUser = false, bool includeMovies = false);
        Task<IEnumerable<List>> GetListsByUserIdAsync(string userId, bool includeUser = false, bool includeMovies = false);
        Task<List<Movie>> GetMoviesByListIdAsync(string listId);
    }
}
