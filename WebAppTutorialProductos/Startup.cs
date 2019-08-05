using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTutorialProductos.Startup))]
namespace WebAppTutorialProductos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
