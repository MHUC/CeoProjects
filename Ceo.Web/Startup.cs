using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ceo.Web.Startup))]
namespace Ceo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
