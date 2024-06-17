using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Events
{
    public class EventManager
    {
        private static readonly Lazy<EventManager> _instance = new Lazy<EventManager>(() => new EventManager());

        public static EventManager Instance => _instance.Value;

        private readonly ConcurrentDictionary<EventType, List<EventHandler>> _eventHandlers;

        private EventManager()
        {
            _eventHandlers = new ConcurrentDictionary<EventType, List<EventHandler>>();

            // Initialize empty event handlers list for each event type
            foreach (EventType eventTypes in Enum.GetValues(typeof(EventType)))
            {
                _eventHandlers[eventTypes] = new List<EventHandler>();
            }
        }

        public void Subscribe(EventType eventType, EventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            if (_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType].Add(handler);
            }
        }

        public void Unsubscribe(EventType eventType, EventHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            if (_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType].Remove(handler);
            }
        }

        // Publish an event, which means calling every handlers of that event
        public void Publish(EventType eventType, object sender, EventArgs args)
        {
            if (_eventHandlers.ContainsKey(eventType))
            {
                List<EventHandler> handlersCopy;
                // Use lock to ensure operations on handers list are performed atomically
                lock (_eventHandlers[eventType])
                {
                    // Prevent collection modification exceptions
                    handlersCopy = new List<EventHandler>(_eventHandlers[eventType]);
                }

                foreach (EventHandler handler in _eventHandlers[eventType])
                {
                    handler?.Invoke(sender, args);
                }
            }
        }
    }
}
