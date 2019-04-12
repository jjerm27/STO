using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(STO.Startup))]
namespace STO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
