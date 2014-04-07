using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class MetodyCalkowania
    {
        public delegate double function(double x);
        public enum Metody { Prostokatow = 1, Trapezow = 2 }
        public double PoczatekPrzedzialu { get; set; }
        public double KoniecPrzedzialu { get; set; }
        public uint LiczbaPodzialow { get; set; }

        public function f;

        public double Trapezow()
        {
            double suma = 0;
            double dx = (KoniecPrzedzialu - PoczatekPrzedzialu) / LiczbaPodzialow;
            double x = PoczatekPrzedzialu;
            for (int i = 1; i < LiczbaPodzialow; i++)
            {
                x += dx;
                suma += f(x);
            }
            x = PoczatekPrzedzialu;
            double tmp = f(x);
            x = KoniecPrzedzialu;
            tmp += f(x);
            suma += tmp / 2;
            suma *= dx;
            return suma;
        }
        public double Prostokatow()
        {
            double suma = 0;
            double dx = (KoniecPrzedzialu - PoczatekPrzedzialu) / LiczbaPodzialow;
            double x = PoczatekPrzedzialu;
            for (int i = 1; i < LiczbaPodzialow; i++)
            {
                x += dx;
                suma += f(x);
            }
            suma *= dx;
            return suma;
        }
    }
}
