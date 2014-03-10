using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_TDD2
{
    public class Game
    {
       public string Say(int p)
        {
            // na switchach
            //switch (p)
            //{
            //    case int.MaxValue:
            //        return "MaxInt";

            //    case int.MinValue:
            //        return "MinInt";
            //}

            //switch(p%15)
            //{
            //    case 0:
            //        return "FissBuzz";
            //}
            //switch (p % 5)
            //{
            //    case 0:
            //        return "Buzz";

            //}
            //switch (p % 3)
            //{
            //    case 0:
            //        return "Fiss";
            //}

            //return p.ToString();


            // na ifach
            if (p == int.MaxValue)
                return "MaxInt";

            if (p == int.MinValue)
                return "MinInt";

            if (p % 15 == 0)
                return "FissBuzz";

            if (p % 3 == 0)
                return "Fiss";

            if (p % 5 == 0)
                return "Buzz";

            return p.ToString();
        }
    }
}
