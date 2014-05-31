using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_testgit1.Startup))]
namespace WebApp_testgit1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
