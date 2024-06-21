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
    public class ListRepository : Repository<List>, IListRepository
    {
        public ListRepository(AppDbContext context) : base(context) { }
    }
}
