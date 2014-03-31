using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Application.Startup))]
namespace MVC_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
