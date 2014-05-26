using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac.Integration.Mvc;
using Autofac.Extras.DynamicProxy2;
using projekt2;

namespace MvcAndAutofac
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Autofac.ContainerBuilder con = new ContainerBuilder();
            con.RegisterControllers(typeof(MvcApplication).Assembly);
            con.RegisterType<SomeLongRunningStuff>().As<ISomeStuff>().InstancePerRequest().EnableInterfaceInterceptors().InterceptedBy(typeof(SomeInterceptor));
            var container = con.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
