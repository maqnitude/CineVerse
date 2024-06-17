using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Events
{
    public class EventSubscriber : IObservable<Event>
    {
        private class Unsubscriber : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        public IDisposable Subscribe(IObserver<Event> observer)
        {
            throw new NotImplementedException();
        }
    }
}
