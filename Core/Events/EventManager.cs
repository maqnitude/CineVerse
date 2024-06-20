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
        private readonly ConcurrentDictionary<EventType, List<Delegate>> _eventHandlers;

        public EventManager()
        {
            _eventHandlers = new ConcurrentDictionary<EventType, List<Delegate>>();

            // Initialize empty event handlers list for each event type
            foreach (EventType eventTypes in Enum.GetValues(typeof(EventType)))
            {
                _eventHandlers[eventTypes] = new List<Delegate>();
            }
        }

        // Publish an event, which means calling every handlers of that event
        public void Publish<TEventArgs>(EventType eventType, object sender, TEventArgs args) where TEventArgs : EventArgs
        {
            if (_eventHandlers.ContainsKey(eventType))
            {
                List<Delegate> handlersCopy;
                // Use lock to ensure operations on handers list are performed atomically
                lock (_eventHandlers[eventType])
                {
                    // Prevent collection modification exceptions
                    handlersCopy = new List<Delegate>(_eventHandlers[eventType]);
                }

                foreach (Delegate handler in handlersCopy)
                {
                    if (handler is EventHandler<TEventArgs> eventHandler)
                    {
                        eventHandler?.Invoke(sender, args);
                    }
                }
            }
        }

        public void Subscribe<TEventArgs>(EventType eventType, EventHandler<TEventArgs> handler) where TEventArgs : EventArgs
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            if (_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType].Add(handler);
            }
        }

        public void Unsubscribe<TEventArgs>(EventType eventType, EventHandler<TEventArgs> handler) where TEventArgs : EventArgs
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            if (_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType].Remove(handler);
            }
        }

        public void UnsubscribeAll(EventType eventType)
        {
            if (_eventHandlers.ContainsKey(eventType))
            {
                _eventHandlers[eventType].Clear();
            }
        }
    }
}
