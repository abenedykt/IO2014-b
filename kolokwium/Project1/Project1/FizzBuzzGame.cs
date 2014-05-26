using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class FizzBuzzGame
    {
        public string GetValue(int i)
        {
            if (i == 0) return "0";
            if (i % 5 == 0 && i % 3 == 0) return "FizzBuzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";

            return i.ToString();
        }
    }
}
