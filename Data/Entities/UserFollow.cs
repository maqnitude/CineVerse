using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Data.Entities
{
    public class UserFollow
    {
        public string FolloweeId { get; set; }
        public User Followee { get; set; }

        public string FollowerId { get; set; }
        public User Follower { get; set; }

        public DateTime FollowedAt { get; set; } = DateTime.UtcNow;
    }
}
