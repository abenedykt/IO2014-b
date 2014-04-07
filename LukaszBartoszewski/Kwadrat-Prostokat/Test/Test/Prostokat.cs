using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Prostokat
    {
        public int a;
        public int b;

        public int obw;
        public int pole;

        public Prostokat(int a, int b1)
        {
            this.a = a;
            b = b1;
        }

        protected Prostokat(int a)
        {
            this.a = a;
            b = a;
        }

        public void LiczObw()
        {
            obw = 2*a + 2*b;
        }

        public void LiczPole()
        {
            pole = a*b;
        }
    }
}
