using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia5_KwadratProstokat
{
    public class Kwadrat:Figura
    {
        private double a;
        public Kwadrat(double a)
        {
            this.a = a;
        }

        public virtual double liczPole()
        {
            return Math.Pow(a,2);
        }

        public double liczObwod()
        {
            return 4 * a;
        }

    }
}
