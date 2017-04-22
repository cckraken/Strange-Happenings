using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strange_Happenings.Startup))]
namespace Strange_Happenings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
