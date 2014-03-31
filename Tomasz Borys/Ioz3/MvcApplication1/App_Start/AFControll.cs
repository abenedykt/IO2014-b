using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using IApp;
using txtRepo;
using IRepo;

namespace MvcApplication1.App_Start
{
    public class AFControll
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof (MvcApplication).Assembly);
            builder.RegisterType<Application>()
                .As<IApplication>()
                .InstancePerHttpRequest();
            builder.RegisterType<TxTRepository>()
                .As<Irepository>()
                .InstancePerHttpRequest();
            builder.RegisterType<IEvents>()
                .As<Event>()
                .InstancePerHttpRequest();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}