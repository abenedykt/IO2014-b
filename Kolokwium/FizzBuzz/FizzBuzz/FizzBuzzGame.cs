using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Game(int i)
        {
            return i%5 == 0 && i%3 == 0 ? "FizzBuzz" : (i%5 == 0 ? "Buzz" : (i%3 == 0 ? "Fizz" : i.ToString()));
        }
    }
}
