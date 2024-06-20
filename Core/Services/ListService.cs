using CineVerse.Core.Interfaces;
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
        private readonly IUnitOfWork _unitOfWork;

        public ListService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateListAsync(string name, ListType listType, string? description)
        {
            var list = new List()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Overview = description,
                Type = listType,
            };

            await _unitOfWork.Lists.AddAsync(list);
            await _unitOfWork.CompleteAsync();
        }
    }
}
