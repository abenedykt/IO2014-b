using FizzBuzzLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_FizzBuzzUI
{
    class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                Console.Write("Podaj cyfrę: ");
                var digit = int.Parse(Console.ReadLine());
                var game = new Game();
                Console.WriteLine(game.say(digit));
            }
        }
    }
}
