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
        Task<Person> GetPersonWithMoviesAsync(int personId);
    }

}
