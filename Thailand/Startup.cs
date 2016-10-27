using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thailand.Startup))]
namespace Thailand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
