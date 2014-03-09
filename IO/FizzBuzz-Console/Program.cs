using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Count()>=2)
            {
                var Game = new zajecia1.Game();
                StreamWriter sw = new StreamWriter("plik.txt");
                for (int i = Int16.Parse(args[0]); i <= Int16.Parse(args[1]); i++)
                {
                    sw.WriteLine(i + " " + Game.Say(i));
                }
                sw.Close();
            }
        }
    }
}
