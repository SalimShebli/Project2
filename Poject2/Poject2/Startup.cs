using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poject2.Startup))]
namespace Poject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
