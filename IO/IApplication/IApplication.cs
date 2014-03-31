using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEvents;

namespace IApplication
{
    public interface IApplication : IEvent
    {
        IEnumerable<IEvent> Events { get; set; }
    }
}
