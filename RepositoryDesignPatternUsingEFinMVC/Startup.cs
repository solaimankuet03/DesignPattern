using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryDesignPatternUsingEFinMVC.Startup))]
namespace RepositoryDesignPatternUsingEFinMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
