using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BroadcastReal_timeSQLdatausingSignalR.Startup))]
namespace BroadcastReal_timeSQLdatausingSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
