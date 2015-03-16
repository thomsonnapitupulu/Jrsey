using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jrsey.Startup))]
namespace Jrsey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
