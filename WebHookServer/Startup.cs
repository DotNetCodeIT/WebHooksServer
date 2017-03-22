using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHookServer.Startup))]
namespace WebHookServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
