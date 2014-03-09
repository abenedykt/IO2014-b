using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zajecia1
{
    public class Game
    {
        public string Say(int p)
        {
            if (p == 0) return null;
            if (p % 5 == 0)
            {
                if (p % 3 == 0)
                    return "FizzBuzz";
                return "Buzz";
            }
            else if (p % 3 == 0)
                return "Fizz";
            return null;

            //switch (p)
            //{
            //    case 0: return null;
            //    case 3: return "Fizz";
            //    case 5: return "Buzz";
            //    case 10: return "Buzz";
            //    case 15: return "FizzBuzz";
            //    case 30: return "FizzBuzz";
            //    default: return null;
            //}

        }
    }
}
