using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jewellery.Startup))]
namespace jewellery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
