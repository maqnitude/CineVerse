using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IListMovieRepository : IRepository<ListMovie>
    {
        Task<ListMovie> GetAsync(string listId, int movieId);
    }
}
