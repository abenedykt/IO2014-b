using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppInterface;
using AppLogic;
using Autofac;

namespace CLIViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            DIContainer.bind();
            IContainer container;
            IApplication App;
            using (container = DIContainer.builder.Build())
            {
                App = container.Resolve<IApplication>();
            }
            
            foreach (IEvent item in App.Events())
            {
                Console.WriteLine(item.Content);
            }
            Console.ReadLine();
        }
    }
}
