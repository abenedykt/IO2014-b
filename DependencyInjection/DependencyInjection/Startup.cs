using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DependencyInjection.Startup))]
namespace DependencyInjection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
