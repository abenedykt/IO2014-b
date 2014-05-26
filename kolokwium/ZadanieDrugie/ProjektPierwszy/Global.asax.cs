using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using ProjektDrugi;

namespace ProjektPierwszy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SomeLongRunningStuff>().As<ISomeStuff>().InstancePerRequest().EnableInterfaceInterceptors().InterceptedBy(typeof(Interceptor));

            builder.Register(c => new Interceptor());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
