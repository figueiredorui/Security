using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Security.Web.Startup))]
namespace Security.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
