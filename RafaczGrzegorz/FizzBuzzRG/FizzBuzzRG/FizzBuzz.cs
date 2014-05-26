using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzRG
{
    public class FizzBuzz
    {
        public string getFizzBuzz(int i)
        {
            if (i%3 == 0 && i%5 == 0) return "FizzBuzz";
            if (i%5 == 0) return "Fizz";
            if (i%3 == 0) return "Buzz";
            else return i.ToString();
        }
    }
}
