using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOZad2
{
    interface IParser
    {
        Dzialka Parse(IEnumerable<string> dzialka);
    }
}
