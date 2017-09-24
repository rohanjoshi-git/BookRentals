using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookRentals.Startup))]
namespace BookRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
