using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface Iparser
    {
        punkt GetSodek(string rekord);
        List<punkt> wierzcholki(string rekord);
    }
}
