using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Substitute
{
    public interface IGeoRepository
    {
        void Add(string numerDzialki, double x, double y, double xMin, double yMin, double xMax, double yMax);
    }
}
