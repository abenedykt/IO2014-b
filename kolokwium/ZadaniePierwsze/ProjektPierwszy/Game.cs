namespace ProjektPierwszy
{
    public class Game
    {
        public string Say(int i)
        {
            if (i == 0)
            {
                return string.Empty;
            }

            if (i % 5 == 0 && i % 3 == 0)
            {
                return "Fizz-Buzz";
            }

            if (i % 3 == 0)
            {
                return "Fizz";
            }

            if (i % 5 == 0)
            {
                return "Buzz";
            }

            return i.ToString();
        }
    }
}
