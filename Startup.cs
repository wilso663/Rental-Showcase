using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalShowcase.Startup))]
namespace RentalShowcase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
