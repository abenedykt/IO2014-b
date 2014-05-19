using System;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using FizzBuzz_MVC.App_Data;

namespace FizzBuzz_MVC
{
    public class IoCConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterInstance(new StandardInterceptor());

            builder.RegisterType<Game>()
                .As<IGame>()
                .InstancePerHttpRequest();

            builder.Register(c => new CallLogger(Console.Out));

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}