using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public interface IRepository
    {
        void Add(string nrDzialki, string x, string y, string minX, string minY, string maxX, string maxY);
    }
}
