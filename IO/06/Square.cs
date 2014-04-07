using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06
{
    class Square
    {
        public double A { get; set; }


        public virtual double GetField()
        {
            return Math.Pow(A, 2);
        }

        public virtual double GetCircuit()
        {
            return A*4;
        }
    }
}
