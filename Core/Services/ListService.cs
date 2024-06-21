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

        public async Task CreateListAsync(string userId, string name, ListType listType, string? description)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var list = new List()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = name,
                    Overview = description,
                    Type = listType,
                    UserId = userId
                };

                await unitOfWork.Lists.AddAsync(list);
                await unitOfWork.CompleteAsync();
            }
        }
    }
}
