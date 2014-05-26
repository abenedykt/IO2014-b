using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using ClassLibrary1;

namespace MvcApplication2
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            Autofac.ContainerBuilder builder = new ContainerBuilder();
            builder.Register<Stuff>(b => new Stuff());
            builder.RegisterControllers(typeof (MvcApplication).Assembly);
          
   


            builder.RegisterType<Stuff>().As<ISomeStuff>().InstancePerLifetimeScope().EnableInterfaceInterceptors().InterceptedBy(typeof(Stuff));
           

           var container = builder.Build();

           DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


      }
    }
}