using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploGoogleAuth.Startup))]
namespace EjemploGoogleAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
