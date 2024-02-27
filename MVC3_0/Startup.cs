using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC3_0.Startup))]
namespace MVC3_0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
