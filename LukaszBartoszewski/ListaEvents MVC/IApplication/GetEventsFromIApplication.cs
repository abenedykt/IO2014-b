using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxtRepo;
using IRepository;
using Application;

namespace IApplication
{
    public class GetEventsFromIApplication
    {
        public IEnumerable<Event> Events()
        {
            var getThem = new GetEventsFromIamRepository();
            return getThem.GetAllEventsFromIamRepository();
        }
    }
}
