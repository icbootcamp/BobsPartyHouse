using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BobsPartyHouse.Startup))]
namespace BobsPartyHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
