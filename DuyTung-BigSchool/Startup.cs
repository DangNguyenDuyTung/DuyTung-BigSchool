using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuyTung_BigSchool.Startup))]
namespace DuyTung_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
