using CineVerse.Data;
using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Services
{
    public class PersonService
    {
        private static PersonService? _instance;

        public static PersonService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonService();
                }
                return _instance;
            }
        }

        private PersonService() { }

        public async Task<List<Movie>> GetTopMoviesByPersonId(int personId, int n=10)
        {
            using (var unitOfWork = new UnitOfWork(new AppDbContext()))
            {
                var movies = await unitOfWork.People.GetTopMoviesByPersonIdAsync(personId, n);
                return movies;
            }
        }
    }
}
