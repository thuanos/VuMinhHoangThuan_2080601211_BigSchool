using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuMinhHoangThuan_2080601211.Startup))]
namespace VuMinhHoangThuan_2080601211
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
