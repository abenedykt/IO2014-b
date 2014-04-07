using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_figures
{
    class SquareC
    {
        virtual public int[] Dimensions { get; set; }

        public SquareC()
        {
            Dimensions = new int[1];
        }
        public int GetP()
        {
            return 4 * Dimensions[0];
        }
    }
}
