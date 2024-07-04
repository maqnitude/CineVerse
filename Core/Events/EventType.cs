using CineVerse.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Events
{
    /// <summary>
    /// The custom event types
    /// </summary>
    public enum EventType
    {
        UserSignedIn,
        UserSettingsChanged,
        UserMovieRated,

        ListAdding,
        ListAdded,

        ListMovieAdding,
        ListMovieAdded,
        ListMovieRemoved,

        WatchlistMovieAdded,
        WatchlistMovieRemoved,

        WatchedListMovieAdded,
        WatchedListMovieRemoved,

        LikedListMovieAdded,
        LikedListMovieRemoved,

        ReviewAdding,
        ReviewAdded,

        RatingChanged,

        PostAdding,
        PostAdded,

        PostReplyAdding,
        PostReplyAdded,

        PostVoteAdded,
        PostVoteChanged,
        PostVoteRemoved,

        CommentReplyAdding,
        CommentReplyAdded,

        CommentVoteAdded,
        CommentVoteChanged,
        CommentVoteRemoved,

        UserFollowed,
        UserUnfollowed,
    }

    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
        
        public UserEventArgs(User user)
        {
            User = user;
        }
    }

    public class ListAddEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ListType Type { get; set; }

        public ListAddEventArgs(string name, string description, ListType type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }

    public class ListMovieEventArgs : EventArgs
    {
        public List<string> ListIds { get; set; }
        public int MovieId { get; set; }
        
        public ListMovieEventArgs(List<string> listIds, int movieId)
        {
            ListIds = listIds;
            MovieId = movieId;
        }
    }

    public class ReviewEventArgs : EventArgs
    {
        public int MovieId { get; set; }
        public double Rating { get; set; }
        public string? Content {  get; set; }

        public ReviewEventArgs(int movieId, double rating, string? content)
        {
            MovieId = movieId;
            Rating = rating;
            Content = content;
        }
    }

    public class RatingEventArgs : EventArgs
    {
        public double Rating { get; set; }

        public RatingEventArgs(double rating)
        {
            Rating = rating;
        }
    }

    public class PostEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Content {  get; set; }

        public PostEventArgs(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public class PostReplyEventArgs : EventArgs
    {
        public string PostId { get; set; }
        public string Content { get; set; }

        public PostReplyEventArgs(string postId, string content)
        {
            PostId = postId;
            Content = content;
        }
    }

    public class PostVoteEventArgs : EventArgs
    {
        public string PostId { get; set; }
        public string UserId { get; set; }
        public bool IsUpvote { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }

        public PostVoteEventArgs(string postId, string userId, bool isUpvote, int upvotes, int downvotes)
        {
            PostId = postId;
            UserId = userId;
            IsUpvote = isUpvote;
            Upvotes = upvotes;
            Downvotes = downvotes;
        }
    }

    public class CommentReplyEventArgs : EventArgs
    {
        public string PostId { get; set; }
        public string ParentCommentId { get; set; }
        public string Content { get; set; }

        public CommentReplyEventArgs(string postId, string parentCommentId, string content)
        {
            PostId = postId;
            ParentCommentId = parentCommentId;
            Content = content;
        }
    }

    public class CommentVoteEventArgs : EventArgs
    {
        public string CommentId { get; set; }
        public string UserId { get; set; }
        public bool IsUpvote { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }

        public CommentVoteEventArgs(string commentId, string userId, bool isUpvote, int upvotes, int downvotes)
        {
            CommentId = commentId;
            UserId = userId;
            IsUpvote = isUpvote;
            Upvotes = upvotes;
            Downvotes = downvotes;
        }
    }

    public class FollowEventArgs : EventArgs
    {
        public string FollowerId {  get; set; }
        public string FolloweeId { get; set; }
        public FollowEventArgs(string followerId, string followeeId)
        {
            FollowerId = followerId;
            FolloweeId = followeeId;
        }
    }
}
