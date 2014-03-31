using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IneApplication
{
    interface IApplication
    {
        IEnumerable<Event> Events();
    }

    internal class Event
    {
          public string Name { get; set; }
    }
}
