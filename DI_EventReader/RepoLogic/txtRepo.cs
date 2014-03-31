using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoInterface;

namespace RepoLogic
{
    public class txtRepo : IRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new List<string> { "Event pierwszy  ", " Event 2 ", " 3rd Event" };
        }
    }
}
