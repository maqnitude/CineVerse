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
    }
}
