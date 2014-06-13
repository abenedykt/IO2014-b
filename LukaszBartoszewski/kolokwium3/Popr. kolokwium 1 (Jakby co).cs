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
	// wart. od 0 do 1. Jest to tak naprawdę w jakim stopniu możemy zmieniać
	// nasz kod (dokonywać modyfikacji). Jeżeli niestabilnośc jest wysoka
	// to nasz kod nie jest optymalny. Jeżeli nasz współ niest. jest wyższy od 'bodajże 0,7" 
	// to jedna zmiana w jednej klasie
	// która zależy od wielu innych powoduje 'wysyp exceptionów"

        // abstrakcyjność
        // Jest to zależność klas abstrakcyjnych, interfejsów, do 
	// ilośi wszystkich klas znajdującyh
        // się w naszym projekcie
	// Im wyższa abstrakcyjność tym kod staję się bardziej "elastyczny"
	// i odwrotnie

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
