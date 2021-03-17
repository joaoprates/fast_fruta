using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FastFruta.Startup))]
namespace FastFruta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
