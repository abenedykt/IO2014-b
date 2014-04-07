using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_figures
{
    class RectangleC : SquareC
    {
        override public int[] Dimensions { get; set; }

        public RectangleC()
        {
            Dimensions = new int[2];

        }
        
        public int GetPerimeter()
        {
            return (2 * Dimensions[0]) + (2 * Dimensions[1]);
        }
    }
}
