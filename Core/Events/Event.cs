using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Events
{
    /// <summary>
    /// Class Event defines the custom event used in EventPublisher and EventSubscriber
    /// </summary>
    public class Event
    {
    }

    public static class Events
    {
        // Examples
        public static readonly Event ListCreated = new();
        public static readonly Event ListChanged = new();
    }
}
