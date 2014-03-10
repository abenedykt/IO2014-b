using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz1
{
   public class Game
    {
  public object Say(int p)
        {
            switch (p)
            {
                case 3:
                    return "Fizz";
                  
                case 5:
                    return "Buzz";
                    
                case 15:
                    return "FizzBuzz";
                    
                case int.MaxValue:
                    return "";

                default: return "Nic";
                   
            }
            //if (p==3)
            //{
            //    return "Fizz";  
            //}
            //if (p == 5)
            //{
            //    return "Buzz";
            //}
            //if (p == 15)
            //{
            //    return "FizzBuzz";
            //}
            //if (p==int.MaxValue)
            //{
            //    return "MaxInt";
            //}
            //else
            //    return "?";
        }
    }
}
