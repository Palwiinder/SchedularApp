using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchedularApp.Startup))]
namespace SchedularApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
