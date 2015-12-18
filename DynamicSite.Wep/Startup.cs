using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicSite.Wep.Startup))]
namespace DynamicSite.Wep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
