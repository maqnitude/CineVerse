using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IUserFollowRepository : IRepository<UserFollow>
    {
        Task<UserFollow> GetFollowAsync(string followerId, string followeeId);
        Task<List<User>> GetFollowersAsync(string userId);
        Task<List<User>> GetFolloweesAsync(string userId);
        Task<bool> IsFollowingAsync(string followerId, string followeeId);
    }
}
