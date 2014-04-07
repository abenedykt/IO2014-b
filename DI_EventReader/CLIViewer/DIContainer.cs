using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppInterface;
using AppLogic;

namespace CLIViewer
{
    public static class DIContainer
    {
        public static ContainerBuilder builder = new ContainerBuilder();

        public static void bind()
        {
            builder.RegisterType<Application>().As<IApplication>();            
        }
        
    }
}
