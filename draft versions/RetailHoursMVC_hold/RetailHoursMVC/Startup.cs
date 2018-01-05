using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetailHoursMVC.Startup))]
namespace RetailHoursMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
