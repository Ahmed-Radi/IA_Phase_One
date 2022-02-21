using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phase1.Startup))]
namespace phase1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
