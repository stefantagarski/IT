using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aud_kolokviumska.Startup))]
namespace aud_kolokviumska
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
