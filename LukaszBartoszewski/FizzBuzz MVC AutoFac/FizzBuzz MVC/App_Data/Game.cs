using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz_MVC.App_Data
{
    public class Game : IGame
    {
        public List<string> fizzBuzz;

        public Game(int value)
        {
            NewGame(value);
        }

        public void NewGame(int value)
        {
            fizzBuzz = new List<string>();
            for (var i = 1; i <= value; i++)
            {
                fizzBuzz.Add(FizzBuzz(i));
            }
        }

        public string FizzBuzz(int value)
        {
            if (value % 3 == 0)
            {
                return value % 5 == 0 ? "FizzBuzz" : "Fizz";
            }

            return value % 5 == 0 ? "Buzz" : value.ToString(CultureInfo.InvariantCulture);
        }
    }
}