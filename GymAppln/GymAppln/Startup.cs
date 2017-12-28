using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymAppln.Startup))]
namespace GymAppln
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
