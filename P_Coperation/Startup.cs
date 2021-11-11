using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P_Coperation.Startup))]
namespace P_Coperation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
