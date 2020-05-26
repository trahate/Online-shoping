using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_shoping.Startup))]
namespace Online_shoping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
