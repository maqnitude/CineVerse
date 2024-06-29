﻿using System;
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
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? AvatarPath { get; set; }

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
