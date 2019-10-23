using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PsMvc.Startup))]
namespace PsMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
