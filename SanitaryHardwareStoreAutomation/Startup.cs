using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SanitaryHardwareStoreAutomation.Startup))]
namespace SanitaryHardwareStoreAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
