using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoachingCenterManagement.Startup))]
namespace CoachingCenterManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
