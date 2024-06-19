using CineVerse.Core.Interfaces;
using CineVerse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context) : base(context) { }

        public async Task<Person> GetPersonWithMoviesAsync(int personId)
        {
            return await _context.Set<Person>().Include(p => p.Credits)
                                               .ThenInclude(c => c.Movie)
                                                .FirstOrDefaultAsync(p => p.Id == personId);
        }
    }
}
