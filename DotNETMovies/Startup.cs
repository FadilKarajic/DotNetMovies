using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNETMovies.Startup))]
namespace DotNETMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
