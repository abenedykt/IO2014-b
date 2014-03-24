using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _04_FizzBuzzMVC.Models;

namespace _01_TDD2
{
    public class Game
    {
       public Value Say(int p)
       {
           if (p == int.MaxValue)
               return new Value {Number = "MaxInt"};

            if (p == int.MinValue)
                return new Value {Number ="MinInt"};

            if (p % 15 == 0)
                return new Value {Number = "FissBuzz"};

            if (p % 3 == 0)
                return new Value {Number = "Fiss"};

            if (p % 5 == 0)
                return new Value {Number ="Buzz"};

            return new Value {Number =p.ToString()};
        }

        public IEnumerable<Value> GetValues(int value)
        {
            var tab = new List<Value>();
            for (int i = 1; i <= value; i++)
            {
                tab.Add(Say(i));
            }
            return tab;
        }
    }
}
