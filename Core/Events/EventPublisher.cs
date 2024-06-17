using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineVerse.Core.Events
{
    public class EventPublisher : IObservable<Event>
    {
        public IDisposable Subscribe(IObserver<Event> observer)
        {
            throw new NotImplementedException();
        }
    }
}
