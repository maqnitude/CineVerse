using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class Post
    {
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        //public int MovieId { get; set; } // only 1 movie for now
        //public Movie Movie { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public int Upvotes { get; set; } = 0;
        public int Downvotes { get; set; } = 0;
        public ICollection<PostVote> Votes { get; set; } = new List<PostVote>();
    }
}
