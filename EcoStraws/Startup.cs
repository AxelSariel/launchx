using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcoStraws.Startup))]
namespace EcoStraws
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
