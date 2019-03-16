using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoBackEnd.Startup))]
namespace ProyectoBackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
