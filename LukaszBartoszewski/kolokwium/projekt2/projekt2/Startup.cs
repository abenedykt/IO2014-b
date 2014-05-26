using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projekt2.Startup))]
namespace projekt2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
