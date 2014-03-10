using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajecia2_Geo
{
    public interface IGeoRepository
    {
        void Add(string nrDzialki,double x,double y,double xMin,double yMin,double xMax,double yMax);
    }
}
