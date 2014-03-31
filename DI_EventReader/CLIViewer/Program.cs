using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppInterface;
using AppLogic;

namespace CLIViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplication App = new Application();
            foreach (IEvent item in App.Events())
            {
                Console.WriteLine(item.Content);
            }
            Console.ReadLine();
        }
    }
}
