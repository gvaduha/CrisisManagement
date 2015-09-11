using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrisisApplication.Startup))]
namespace CrisisApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
