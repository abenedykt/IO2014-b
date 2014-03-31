using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zajecia4_EventsIRepository
{
    public interface IRepository
    {
        IEnumerable<EventModel> GetAllEvents();
        XDocument ReadXMLFromFile(string url);
    }
}
