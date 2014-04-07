using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia5_KwadratProstokat
{
    public class Prostokat:Figura
    {
        private double a;
        private double b;
        public Prostokat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public virtual double liczObwod()
        {
            return (2 * a) + (2 * b);
        }

        public double liczPole()
        {
            return a * b;
        }               
    }
}
