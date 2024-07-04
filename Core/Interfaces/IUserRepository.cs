using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> GetPublicUsersAsync();
        Task<User> GetUserByIdAsync(string id);
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetUserByEmailAsync(string email);
        Task<List<Movie?>> GetFavouriteMoviesByIds(List<int?> movieIds);
    }
}
