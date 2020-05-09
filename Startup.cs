using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalStore.Startup))]
namespace RentalStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
