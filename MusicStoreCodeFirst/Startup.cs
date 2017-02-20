using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStoreCodeFirst.Startup))]
namespace MusicStoreCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
