using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Kwadrat : Prostokat
    {
        public Kwadrat(int a) : base(a)
        {
            this.a = a;
            b = a;
        }
    }
}
