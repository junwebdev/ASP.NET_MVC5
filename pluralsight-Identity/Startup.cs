using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pluralsight_Identity.Startup))]
namespace pluralsight_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
