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

        ListAdding,
        ListAdded,

        ListMovieAdding,
        ListMovieAdded,

        ReviewAdding,
        ReviewAdded,

        StarClicked,
    }

    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
        
        public UserEventArgs(User user)
        {
            User = user;
        }
    }

    public class ListEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ListType Type { get; set; }

        public ListEventArgs(string name, string description, ListType type)
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
}
