using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NEO_natal.Startup))]
namespace NEO_natal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
