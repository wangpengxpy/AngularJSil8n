using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSil8n.Startup))]
namespace AngularJSil8n
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
