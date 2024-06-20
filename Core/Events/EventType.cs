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
    }

    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
        
        public UserEventArgs(User user)
        {
            User = user;
        }
    }
}
