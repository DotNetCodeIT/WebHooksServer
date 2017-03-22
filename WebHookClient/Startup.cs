using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHookClient.Startup))]
namespace WebHookClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
