using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FizzMVC.Startup))]
namespace FizzMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
