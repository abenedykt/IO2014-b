using System;
using System.ComponentModel;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using projekt2.Models;
using projekt2_2;

namespace projekt2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //AutoFac
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SomeLongRunningStuff>().
                As<ISomeStuff>().InstancePerDependency().
                EnableInterfaceInterceptors().
                InterceptedBy(typeof(MyOwnInterceptor));

            var interceptor = new MyOwnInterceptor();
            builder.RegisterInstance(interceptor);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
