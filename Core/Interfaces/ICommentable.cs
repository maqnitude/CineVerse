using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Interfaces
{
    public interface ICommentable
    {
        string Id { get; set; }
        string Content { get; set; }
        string UserId { get; set; }
        User User { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        ICollection<Comment> Replies { get; set; }
        int Upvotes {  get; set; }
        int Downvotes { get; set; }
    }
}
