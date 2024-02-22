using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMC3_0.Startup))]
namespace VMC3_0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
