using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAplication;
using IRepository;

namespace Application
{
    class App : IApplication
    {
        public IEnumerable<Event> Events()
        {
            var repo = new Repo();
            var enumerable = repo.GetAll();
            var events = enumerable.Select(s => new Event() {Name = s}).ToList();

            return events.AsEnumerable();
        }
    }
}
