using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public enum ProfileVisibility
    {
        Private,
        Friends,
        Public,
    }

    public class User
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? GivenName { get; set; }
        public string? FamilyName { get; set;}
        public ProfileVisibility ProfileVisibility { get; set; } = ProfileVisibility.Public;
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? AvatarPath { get; set; }
        public string? Location { get; set; }
        public string? Website { get; set; }
        public string? Bio { get; set; }

        public string WatchlistId { get; set; }
        public List Watchlist {  get; set; }

        public string WatchedListId { get; set; }
        public List WatchedList { get; set; }

        public string LikedListId { get; set; }
        public List LikedList {  get; set; }

        public ICollection<List> Lists { get; set; } = new List<List>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<PostVote> PostVotes { get; set; } = new List<PostVote>();
        public ICollection<CommentVote> CommentVotes { get; set; } = new List<CommentVote>();

        public ICollection<UserFollow> Followers { get; set; } = new List<UserFollow>();
        public ICollection<UserFollow> Followees { get; set; } = new List<UserFollow>(); 

        public User()
        {
            Watchlist = new List
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Watchlist",
                Type = ListType.Private,
                UserId = Id
            };
            WatchedList = new List
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Watched List",
                Type = ListType.Private,
                UserId = Id
            };
            LikedList = new List
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Liked",
                Type = ListType.Private,
                UserId = Id
            };

            WatchlistId = Watchlist.Id;
            WatchedListId = WatchedList.Id;
            LikedListId = LikedList.Id;

            Lists.Add(WatchedList);
            Lists.Add(Watchlist);
            Lists.Add(LikedList);
        }
    }
}
