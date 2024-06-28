using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class CommentVote
    {
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }
        [Required]
        public string CommentId { get; set; }
        public Comment Comment { get; set; }
        [Required]
        public bool IsUpvote { get; set; }
    }
}
