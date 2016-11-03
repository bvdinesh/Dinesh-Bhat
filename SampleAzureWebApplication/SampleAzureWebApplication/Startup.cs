using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleAzureWebApplication.Startup))]
namespace SampleAzureWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
