using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComedyCentral.Startup))]
namespace ComedyCentral
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
