using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TradingPartnerMVC.Startup))]
namespace TradingPartnerMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
