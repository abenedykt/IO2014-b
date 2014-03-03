using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zajecia1_FizzBazz_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0]!=null)
            {
                int myNumber = int.Parse(args[0]);
                var game=new Zajecia1_FizzBuzz.Game();
                using (System.IO.StreamWriter file = System.IO.File.CreateText("myFile.txt"))
                {
                    for (int i = 1; i <= myNumber; i++)
                    {
                        file.WriteLine(string.Format("i:{0}\t{1}", i, game.Say(i)));
                    }
                    file.Close();
                }
                
            }
            else
            {
                Console.WriteLine("Nie podano parametru!\nKONIEC");
                Console.ReadKey();
            }
        }
    }
}
