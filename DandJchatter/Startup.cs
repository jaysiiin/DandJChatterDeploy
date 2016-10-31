using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DandJchatter.Startup))]
namespace DandJchatter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
