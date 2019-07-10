using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FundAChild.WebUI.Startup))]
namespace FundAChild.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
