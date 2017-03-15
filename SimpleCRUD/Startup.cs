using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleCRUD.Startup))]
namespace SimpleCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
