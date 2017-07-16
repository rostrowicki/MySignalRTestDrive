using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SingalRChat.Startup))]
namespace SingalRChat
{ 
    public class Startup
    {
        public void Configuration(IAppBuilder app)
    {
        app.MapSignalR();
    }
    }
}