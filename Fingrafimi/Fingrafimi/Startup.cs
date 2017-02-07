using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fingrafimi.Startup))]
namespace Fingrafimi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
