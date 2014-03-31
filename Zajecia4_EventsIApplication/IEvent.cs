using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajecia4_EventsIApplication
{
    public interface IEvent
    {
        string Name { get; set; }
        string Where { get; set; }
    }
}
