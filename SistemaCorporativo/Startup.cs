using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaCorporativo.Startup))]
namespace SistemaCorporativo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
