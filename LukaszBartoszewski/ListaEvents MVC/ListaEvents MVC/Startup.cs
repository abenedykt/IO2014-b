using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ListaEvents_MVC.Startup))]
namespace ListaEvents_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
