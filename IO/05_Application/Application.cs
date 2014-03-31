using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Repository;

namespace _05_Application
{
    public class Application : IApplication
    {
        private IRepository _repository;

        public Application(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<_05_Event.IEvent> Events()
        {
            throw new NotImplementedException();
        }
    }
}
