using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackingTime.Startup))]
namespace TrackingTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
