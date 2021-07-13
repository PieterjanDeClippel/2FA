using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticatorTest2.Startup))]
namespace AuthenticatorTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
