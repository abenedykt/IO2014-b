using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Extras.DynamicProxy2;
using App;
using System.Reflection;

namespace WebApplication1.Tests
{
    public class MvcApplicationInstance
    {
        public static MvcApplication Instance
        {
            get
            {
                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterControllers(typeof(MvcApplication).Assembly);

                builder.RegisterType<SomeStuff>().As<ISomeStuff>().InstancePerRequest().EnableInterfaceInterceptors().InterceptedBy(typeof(MyInterceptor)).InstancePerRequest();
                builder.Register(n => new MyInterceptor());

                var container = builder.Build();
                return container.BeginLifetimeScope().Resolve<MvcApplication>();
            }
        }

        public static List<Type> GetSubClasses<T>()
        {
            return Assembly.GetCallingAssembly().GetTypes().Where(
                type => type.IsSubclassOf(typeof(T))).ToList();
        }

        public static List<string> GetControllerNames()
        {
            List<string> controllerNames = new List<string>();
            GetSubClasses<Controller>().ForEach(
                type => controllerNames.Add(type.Name));
            return controllerNames;
        }
    }
}
