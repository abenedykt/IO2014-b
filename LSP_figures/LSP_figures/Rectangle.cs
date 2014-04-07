using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_figures
{
    public class Rectangle : IFigure
    {
        public float[] Dimensions { get; set; }
        public Rectangle()
        {
            Dimensions = new float[2];

        }
        
        public float GetPerimeter()
        {
            return (2 * Dimensions[0]) + (2 * Dimensions[1]);
        }
    }
}
