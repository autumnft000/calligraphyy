using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calligraphy.Startup))]
namespace Calligraphy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
