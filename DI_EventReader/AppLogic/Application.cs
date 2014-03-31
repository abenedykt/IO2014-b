using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoInterface;
using AppInterface;
using RepoLogic;

namespace AppLogic
{
    public class Application : IApplication
    {
        public IEnumerable<IEvent> Events()
        {
            List<Event> Events = new List<Event>();
            IRepository repo = new txtRepo();
            List<string> Fetched = repo.GetAll().ToList<string>();
            foreach (string i in Fetched)
            {
                Event E = new Event();
                E.Content = i.Trim();
                Events.Add(E);
            }

            return Events;
        }
    }
}
