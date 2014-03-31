using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxtRepo;

namespace IApplication
{
    public interface IApplication
    {
        IEnumerable<Event> Events();
    }
}
