using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Miniprojekt.Startup))]
namespace Miniprojekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
