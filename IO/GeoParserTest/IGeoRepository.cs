using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoParserTest
{
    public interface IGeoRepository
    {
        void Add(string numerDzialki, double x, double y, double minX, double minY, double maxX, double maxY);
    }
}
