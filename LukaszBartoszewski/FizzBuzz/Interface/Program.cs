using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using System.IO;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();

            Console.WriteLine("Podaj ilosc zapytan:");

            string max1 = Console.ReadLine();

            int max = Convert.ToInt32(max1);

            string plik = "";

            for (int i = 1; i <= max; i++)
            {
                plik += Game.Say(i) + " ";
            }

            StreamWriter file = new System.IO.StreamWriter("D:\\test.txt");
            file.WriteLine(plik);
            file.Close();
        }
    }
}
