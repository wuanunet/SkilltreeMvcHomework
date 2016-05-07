using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkilltreeMvcHomework.Startup))]

namespace SkilltreeMvcHomework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}