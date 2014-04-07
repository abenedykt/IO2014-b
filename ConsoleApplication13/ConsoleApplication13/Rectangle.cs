using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Rectangle : Shape
    {
        public int x { get; set; }

        public override double CalculateCircuite()
        {
            return 4 * x;
        }
    }
}
