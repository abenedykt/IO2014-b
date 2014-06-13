using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeLongRunningStuff
{
    public class Fun
    {
        // niestabilność oraz abstrakcyjność

        // niestabilność
        // I = Ce / (Ce + Ca)
        // Ce (efferent Coupling) - ilośc klas od których nasza klasa jest zależna
        // Ca (afferent coupling) - ilość klas zależnych od naszej klasy

        // abstrakcyjność
        // Jest to zależność klas abstrakcyjnych, interfejsów, do ilośi wszystkich klas znajdującyh
        // się w naszym projekcie


        //Złożoność 1
        public double func_1(int a, int b)
        {
            return a*a + 2*a*b + b*b;
        }


        //Złożoność 2
        public string func_2(int a, int b)
        {
            var k = func_1(a, b);

            if (k > 0)
            {
                return "ok";
            }
            else
            {
                return "fail";
            }
        }
    }
}
