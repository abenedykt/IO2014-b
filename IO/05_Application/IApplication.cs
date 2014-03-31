using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Event;

namespace _05_Application
{
    public interface IApplication
    {
        IEnumerable<IEvent> Events();
    }
}
