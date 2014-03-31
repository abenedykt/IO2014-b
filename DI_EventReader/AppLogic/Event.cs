using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppInterface;

namespace AppLogic
{
    public class Event : IEvent
    {
        public string Content { get; set; }
    }
}
