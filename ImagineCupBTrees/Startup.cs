using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImagineCupBTrees.Startup))]
namespace ImagineCupBTrees
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
