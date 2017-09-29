using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstWebASPNETMVCApplication.Startup))]
namespace FirstWebASPNETMVCApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
