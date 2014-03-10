using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tbz1;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.GetCommandLineArgs().Length == 3)
            {
                string filename = Environment.GetCommandLineArgs()[1].ToString();
                int a = Convert.ToInt32(Environment.GetCommandLineArgs()[2]);
                StreamWriter sw = new StreamWriter(filename);
                var game = new Game();
                for (int i = 0; i < a; i++)
                {
                    var q = game.Say(i);
                    sw.WriteLine(q);
                }
                sw.Close();
            }

        }
    }
}
