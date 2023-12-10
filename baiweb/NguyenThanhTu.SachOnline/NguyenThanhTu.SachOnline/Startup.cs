using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDD.SachOnline.Startup))]
namespace PDD.SachOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
