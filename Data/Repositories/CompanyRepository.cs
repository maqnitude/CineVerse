﻿using CineVerse.Core.Interfaces;
using CineVerse.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context) { }

        public async Task<Company> GetCompanyWithMoviesAsync(int companyId)
        {
            return await _context.Set<Company>().Include(c => c.Movies).FirstOrDefaultAsync(c => c.Id == companyId);
        }
    }
}
