using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObwodTest
{
    public class Prostokat : Kwadrat
    {
        public int B { get; set; }

        public override int Obwod()
        {
            return 2*A + 2*B;
        }
    }
}
