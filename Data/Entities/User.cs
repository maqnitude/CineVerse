using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        //public string? GivenName { get; set; }
        //public string? FamilyName { get; set;}
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? AvatarPath { get; set; }
        //public string? Location { get; set; }
        //public string? Website { get; set; }
        //public string? Bio { get; set; }

        public ICollection<List> Lists { get; set; } = new List<List>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<PostVote> PostVotes { get; set; } = new List<PostVote>();
        public ICollection<CommentVote> CommentVotes { get; set; } = new List<CommentVote>();
    }
}
