using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Web.Mvc;
using System.Reflection;
using Autofac.Integration.Mvc;

namespace Autofack.DAL
{
    public class BootStrap
    {
        public IContainer myContainer { get; private set; }

        public void Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            OnConfigure(builder);

            if (this.myContainer == null)
            {
                this.myContainer = builder.Build();
            }
            else
            {
                builder.Update(this.myContainer);
            }

            DependencyResolver.SetResolver(new AutofacDependencyResolver(this.myContainer));
        }


        protected virtual void OnConfigure(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<DAL>().As<IDAL>().InstancePerLifetimeScope();
        }
    }
}