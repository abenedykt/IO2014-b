using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAndAutofac.Startup))]
namespace MvcAndAutofac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
