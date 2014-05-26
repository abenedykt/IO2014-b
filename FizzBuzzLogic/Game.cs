using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLogic
{
    public class Game
    {
        public object say(int p)
        {
            if (p == int.MaxValue)
                return "MaxInt";
            if (p == int.MinValue)
                return "MinInt";
            if (p % 15 == 0)
                return "FizzBazz";
            if (p % 5 == 0)
                return "Bazz";
            if (p % 3 == 0)
                return "Fizz";

            return p.ToString();
        }
    }
}
