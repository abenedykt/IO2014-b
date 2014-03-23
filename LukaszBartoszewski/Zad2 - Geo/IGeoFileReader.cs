using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }
}
