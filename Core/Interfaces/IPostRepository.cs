using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        Task<IEnumerable<Post>> GetPostsByPageAsync(int page, int pageSize);
        Task<Post> GetPostByIdAsync(string postId);
        Task<IEnumerable<Comment>> GetPostRepliesAsync(string postId);
        Task<int> CountPostRepliesAsync(string postId);
    }
}
