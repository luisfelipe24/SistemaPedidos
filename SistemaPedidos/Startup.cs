using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaPedidos.Startup))]
namespace SistemaPedidos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
