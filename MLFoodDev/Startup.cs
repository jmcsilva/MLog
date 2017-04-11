using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MLFoodDev.Startup))]
namespace MLFoodDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
