using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MulitpleModelsDemo.Startup))]
namespace MulitpleModelsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
