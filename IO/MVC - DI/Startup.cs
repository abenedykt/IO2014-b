using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC___DI.Startup))]
namespace MVC___DI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
