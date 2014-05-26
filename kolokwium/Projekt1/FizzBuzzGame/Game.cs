using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class Game
    {
        public string Say(int value)
        {
            if (value == 0) return "0";
            if (value%3 == 0)
            {
                if (value%5 == 0)
                    return "FizzBuzz";
                return "Fizz";
            }
            if (value % 5 == 0)
                return "Buzz";
            return value.ToString();
        }
    }
}
