using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public interface IGeoRepository
    {
        void Add(string nrdzialki, string maxx, string maxy, string minx, string miny);
    }
}
