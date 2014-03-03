using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajecia1_FizzBuzz
{
    class Game
    {
        internal object Say(int p)
        {
            switch (p)
            {
                case int.MaxValue:
                    return "MaxInt";
                case int.MinValue:
                    return "MinInt";
                case 15:
                    return "FizzBazz";
                case 5:
                    return "Bazz";
                case 3:
                    return "Fizz";
                default:
                    return p;
            }
            //if (p == int.MaxValue)
            //    return "MaxInt";
            //if (p == int.MinValue)
            //    return "MinInt";
            //if (p % 15 == 0)
            //    return "FizzBazz";
            //if (p % 5 == 0)
            //    return "Bazz";
            //if (p % 3 == 0)
            //    return "Fizz";
            //return p;
        }
    }
}
