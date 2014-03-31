using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event;

namespace Application
{
    public interface IApplication
    {
        IEnumerable<Event.IEvent> Events { get; set; }
    }
}
