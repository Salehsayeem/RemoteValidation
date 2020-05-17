using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemoteValidation.Startup))]
namespace RemoteValidation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
