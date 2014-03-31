using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace FizzBuzz_MVC.Models
{
    public class Game
    {
        public List<string> FizzBuzz = new List<string>();

        public Game(int value)
        {
            for (var i = 1; i <= value; i++)
            {
                FizzBuzz.Add(fizzBuzz(i));
            }
        }

        private string fizzBuzz(int value)
        {
            if (value%3 == 0)
            {
                return value%5 == 0 ? "FizzBuzz" : "Fizz";
            }

            return value % 5 == 0 ? "Buzz" : value.ToString(CultureInfo.InvariantCulture);
        }
    }
}