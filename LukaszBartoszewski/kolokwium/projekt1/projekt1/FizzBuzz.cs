using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt1
{
    public class FizzBuzz
    {
        public string GetValue(int number)
        {
            if (number%3 == 0 && number%5 == 0)
                return "FizzBuzz";

            if (number%3 == 0)
                return "Fizz";

            return number%5 == 0 ? "Buzz" : number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
