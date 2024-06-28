using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<List<Movie>> GetTopMoviesByPersonIdAsync(int personId, int n);
        Task<Person> GetPersonWithMoviesAsync(int personId);
    }

}
