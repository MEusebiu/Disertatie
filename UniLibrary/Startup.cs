using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniLibrary.Startup))]
namespace UniLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
