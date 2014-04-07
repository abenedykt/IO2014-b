using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Prostokat
    {
        public int a { get; set; }
        public int b { get; set; }

        public int obwk()
        {
            return 4*a;
        }
        public int obwp()
        {
            return (2 * a)+(2 * b);
        }
       
    }
}
