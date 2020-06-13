using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HMSystem.Startup))]
namespace HMSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
