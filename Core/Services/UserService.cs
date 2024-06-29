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

        public async Task UpdateUser(User user)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                unitOfWork.Users.Update(user);
                await unitOfWork.CompleteAsync();
            }
        }
    }
}
