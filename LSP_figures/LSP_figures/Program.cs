using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure f1 = new Square();
            IFigure f2 = new Square();
            IFigure f3 = new Rectangle();

            f1.Dimensions[0] = 3;
            f2.Dimensions[0] = 5;
            f3.Dimensions[0] = 2;
            f3.Dimensions[1] = 7;

            Console.WriteLine(f1.GetPerimeter());
            Console.WriteLine(f2.GetPerimeter());
            Console.WriteLine(f3.GetPerimeter());

            Console.WriteLine();

            SquareC s1 = new SquareC();
            SquareC s2 = new RectangleC();
            s1.Dimensions[0] = 2;
            s2.Dimensions[0] = 3;
            s2.Dimensions[1] = 4;

            Console.WriteLine(s1.GetP());
            Console.WriteLine(s2.GetP());


            Console.ReadKey();
        }
    }
}
