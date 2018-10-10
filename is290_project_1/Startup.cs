using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(is290_project_1.Startup))]
namespace is290_project_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
