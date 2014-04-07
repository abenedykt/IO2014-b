using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObwodTest
{
    public class Kwadrat
    {
        public int A { get; set; }
        public virtual int Obwod()
        {
            return 4*A;
        }
    }
}
