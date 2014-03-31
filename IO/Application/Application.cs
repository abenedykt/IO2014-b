using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application
{
    public class Application : IApplication.IApplication
    {
        public IEnumerable<string> Events { get; set; }

        public Application()
        {
            var _events = new Repository.Repository();
            Events = _events.GetAllEvents();
        }
    }
}
