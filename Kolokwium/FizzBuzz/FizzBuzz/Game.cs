using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Game
    {
        public object Say(int p)
        {
            if (p == int.MaxValue)
                return "MaxInt";
            if (p == int.MinValue)
                return "MinInt";
            if(p<1)
                return "Lower then one";
            if (p%15 == 0)
                return "FizzBuzz";
            if (p%5 == 0)
                return "Buzz";
            return "Fizz";
        }
    }
}
