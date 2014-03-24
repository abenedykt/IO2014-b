using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class Game
    {
        public string Say(int s)
        {

            if (s % 3 == 0 && s % 5 == 0)
                return "FizzBuzz";

            if (s % 3 == 0)
                return "Fizz";

            if(s%5 == 0)
                return "Buzz";

            return s.ToString();
        }
    }
}
