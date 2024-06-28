using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class Comment
    {
        public string Id { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        [Required]
        public string PostId { get; set; }
        public Post Post { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public string ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
        public ICollection<Comment> Replies { get; set; } = new List<Comment>();

        public int Upvotes { get; set; } = 0;
        public int Downvotes { get; set; } = 0;
        public ICollection<CommentVote> Votes { get; set; } = new List<CommentVote>();
    }
}
