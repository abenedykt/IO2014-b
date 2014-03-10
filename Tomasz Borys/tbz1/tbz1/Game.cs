using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tbz1
{
   public class Game
    {
        public string Say(int p)
        {
            /*if (p == 0) return Convert.ToString(p);
            else if (p % 15 == 0) return "FizzBuzz";
            else if (p % 3 == 0) return "Fizz";
            else if (p % 5 == 0) return "Buzz";
            else return Convert.ToString(p);*/
            switch(p)
            {
                case 0: return "0";
            }
            switch (p % 15)
            {
                case 0: return "FizzBuzz";
            }
            switch(p%3)
            {
                case 0: return "Fizz";
            }
            switch(p%5)
            {
                case 0: return "Buzz";
            }
            return p.ToString();
        }
    }
}
