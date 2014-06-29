using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleDo.Web.Startup))]
namespace SimpleDo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
