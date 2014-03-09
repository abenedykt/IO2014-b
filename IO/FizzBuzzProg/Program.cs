using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Policy;
using FizzBuzz;

namespace FizzBuzzProg
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args!=null)
            {
                var game = new Game();
                var i = int.Parse(args.Last());
                var writer = new StreamWriter(@"D:\MyTest.txt");
                for (int j = int.Parse(args.First()); j < i; j++)
                {
                    writer.WriteLine(j + " " + game.Say(j));
                }
                writer.Close();
            }
        }
    }
}
