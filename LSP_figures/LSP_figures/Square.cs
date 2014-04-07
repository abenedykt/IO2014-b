using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_figures
{
    public class Square : IFigure
    {
        public float[] Dimensions { get; set; }

        public Square()
        {
            Dimensions = new float[1];
        }

        public float GetPerimeter()
        {
            return 4 * Dimensions[0];
        }
    }
}
