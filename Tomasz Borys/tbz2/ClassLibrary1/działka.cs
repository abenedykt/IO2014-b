using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tbz2
{
    public class działka
    {
        punkt srodek;
        List<punkt> wierzcholki;
        public działka(int x, int y)
        {
            srodek.x = x;
            srodek.y = y;
        }
        public void dodajWierzcholek(int x, int y)
        {
            wierzcholki.Add(new punkt(x,y));
        }
    }
}
