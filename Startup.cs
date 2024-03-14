using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetsApp.Startup))]
namespace PetsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
