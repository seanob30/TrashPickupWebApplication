using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrashPickupWebApplication.Startup))]
namespace TrashPickupWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
