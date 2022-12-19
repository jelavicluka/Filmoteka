using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filmoteka.Startup))]
namespace Filmoteka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
