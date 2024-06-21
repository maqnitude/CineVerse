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

        ReviewAdding,
        ReviewAdded,
    }

    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
        
        public UserEventArgs(User user)
        {
            User = user;
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
