using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _01_TDD2;
using System.IO;

namespace TDD_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int start;
            int end;
            try
            {
                start = Convert.ToInt32(args[0]);
                end = Convert.ToInt32(args[1]);
            }
            catch (Exception)
            {
                return;
            }


            if (end < start)
                return;


            var fileName = "plik.txt";
            Game game = new Game();
            using (var sw = new StreamWriter(fileName))
            {
                for (int i = start; i <= end; i++)
                {
                    sw.WriteLine(game.Say(i));
                }
            }
        }
    }
}
