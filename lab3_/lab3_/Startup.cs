using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_.Startup))]
namespace lab3_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
