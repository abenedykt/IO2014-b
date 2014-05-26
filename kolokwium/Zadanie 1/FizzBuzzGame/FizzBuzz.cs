using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string Solve(int p)
        {
            if (p % 15 == 0) return "FizzBuzz";
            if (p % 3 == 0) return "Fizz";
            if (p % 5 == 0) return "Buzz";            
            return p.ToString();
        }
    }
}
