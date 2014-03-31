using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Event;

namespace Application
{
    public class Application : IApplication
    {
        public IEnumerable<IEvent> Events { get; set; }

        public Application()
        {
            var _events = new Repository.TxtRepository("text.txt");
            _events.GetAllEvents();
        }
    }
}
