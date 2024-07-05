using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<Comment> GetCommentByIdAsync(string commentId);
        Task<IEnumerable<Comment>> GetCommentRepliesAsync(string commentId);
        Task<List<Comment>> GetRecentCommentsAsync(int count);
    }
}
