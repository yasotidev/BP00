using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BP00.Scaffolding.Startup))]

namespace BP00.Scaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
