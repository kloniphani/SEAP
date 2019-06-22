using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEAP.Startup))]
namespace SEAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
