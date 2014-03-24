using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Zajecia3_MVCAngular.Controllers
{
    public class HomeController : ApiController
    {
        public string[] GetNumbersFromServer(string number)
        {
            int digit = int.Parse(number);
            string[] numbers=new string[digit];
            for (int i = 1  ; i <= digit; i++)
            {
                if (i%3==0)
                {
                    numbers[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    numbers[i] = "Bazz";
                }
                else if (i % 15 == 0)
                {
                    numbers[i] = "FizzBazz";
                }
                else
                {
                    numbers[i] = i.ToString();
                }
            }
            return numbers;
        }
    }
}
