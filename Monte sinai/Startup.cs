using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Monte_sinai.Startup))]
namespace Monte_sinai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
