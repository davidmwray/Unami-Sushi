using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnamiSushi.Startup))]
namespace UnamiSushi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
