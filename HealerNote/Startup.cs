using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealerNote.Startup))]
namespace HealerNote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
