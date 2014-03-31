using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Event : IEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
