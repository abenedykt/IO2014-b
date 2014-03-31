using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Zajecia4_EventsIRepository;

namespace Zajecia4_EventsRepository
{
    public  class Repository:IRepository
    {
        public XDocument ReadXMLFromFile(string url)
        {
            return XDocument.Load(url);
        }

        public IEnumerable<EventModel> GetAllEvents()
        {
            XDocument content = ReadXMLFromFile("events.xml");
            return content.Elements("event").Select(n => new EventModel { Name = n.Element("name").Value, Where = n.Element("where").Value });
        }

    }
}
