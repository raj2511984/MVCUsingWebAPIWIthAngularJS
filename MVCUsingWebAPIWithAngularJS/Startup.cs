using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCUsingWebAPIWithAngularJS.Startup))]
namespace MVCUsingWebAPIWithAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
