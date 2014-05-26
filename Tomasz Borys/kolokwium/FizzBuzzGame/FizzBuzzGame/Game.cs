using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGra
{
    public class Game
    {
        public string play(int a)
        {
            if (a % 5 == 0 && a % 3 == 0) return "FizzBuzz";
            if (a % 3 == 0) return "Fizz";
            if (a % 5 == 0) return "Buzz";
            return a.ToString();
        }
    }
}
