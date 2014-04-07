using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
    class Prostokat
    {

        public int X { get; set; }

        public int Y { get; set; }

        public int liczPole()
        {
            return X * Y;
        }

        public int liczObwod()
        {
            return 2 * X + 2 * Y;
        }
    }
}
