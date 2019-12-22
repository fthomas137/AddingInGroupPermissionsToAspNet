using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddingInGroupPermissionsToAspNetProject.Startup))]
namespace AddingInGroupPermissionsToAspNetProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
