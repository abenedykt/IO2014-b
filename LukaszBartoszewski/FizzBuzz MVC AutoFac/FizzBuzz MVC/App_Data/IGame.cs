using System.Collections.Generic;
using System.Globalization;

namespace FizzBuzz_MVC.App_Data
{
    public interface IGame
    {
        void NewGame(int value);
        string FizzBuzz(int value);

    }
}