using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektMVC.Startup))]
namespace ProjektMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
