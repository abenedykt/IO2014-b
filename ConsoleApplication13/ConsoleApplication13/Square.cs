using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Square : Shape
    {
        public int y { get; set; }

        public int x { get; set; }

        public override double CalculateCircuite()
        {
            return x * 2 + 2 * y;
        }
    }
}
