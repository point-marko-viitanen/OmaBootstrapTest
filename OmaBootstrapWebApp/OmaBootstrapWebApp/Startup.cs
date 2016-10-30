using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OmaBootstrapWebApp.Startup))]
namespace OmaBootstrapWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
