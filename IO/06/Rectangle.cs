using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06
{
    class Rectangle : Square
    {
        public int B { get; set; }

        public override double GetField()
        {
            return A*B;
        }

        public override double GetCircuit()
        {
            return 2*A + 2*B;
        }
    }
}
