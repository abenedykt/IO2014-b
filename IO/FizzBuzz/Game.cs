namespace FizzBuzz
{
    public class Game
    {
        public string Say(int p)
        {
            //switch (p)
            //{
            //    case 3: return "Fizz";
            //    case 5: return "Buzz";
            //    case 15: return "Fizz-Buzz";
            //    case int.MaxValue: return null;
            //    case int.MinValue: return null;
            //    default:
            //        return string.Empty;
            //}
            if (p == 0)
                return string.Empty;
            if (p % 5 == 0 && p % 3 == 0)
                return "Fizz-Buzz";
            if (p % 3 == 0)
                return "Fizz";
            if (p % 5 == 0)
                return "Buzz";
            return null;
        }
    }
}
