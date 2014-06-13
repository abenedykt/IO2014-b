using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using SomeLongRunningStuff;
using SomeLongRunningStuff.ProjektDrugi;

namespace ProjektMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SomeLongRunningClass>().
                As<ISomeStuff>().InstancePerRequest().
                EnableInterfaceInterceptors().
                InterceptedBy(
                typeof(InterceptorCatchEx), 
                typeof(InterceptorCheckTime));

            builder.Register(c => new InterceptorCatchEx());
            builder.Register(c => new InterceptorCheckTime());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
