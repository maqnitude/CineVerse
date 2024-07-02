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
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Post>> GetPostsByPageAsync(int page, int pageSize)
        {
            IQueryable<Post> query = _context.Set<Post>()
                .Include(p => p.User);

            return await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        }
    }
}
