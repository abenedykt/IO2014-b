using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_05_MVC.Startup))]
namespace _05_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
