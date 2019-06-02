using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Aud_Albums.Startup))]
namespace MVC_Aud_Albums
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
