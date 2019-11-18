using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projekcik.Startup))]
namespace projekcik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
