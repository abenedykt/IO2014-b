using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using Kolokwium_MvcAutofacRepo;
using Kolokwium_MvcAutofacUI.DataAccessLayer;
using Kolokwium_MvcAutofacUI.Interceptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Kolokwium_MvcAutofacUI
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

            builder
                .RegisterType<SomeLongRunningStuff>()
                .As<ISomeStuff>()
                .InstancePerRequest()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TimeLogger));
            builder.Register(n => new TimeLogger());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
