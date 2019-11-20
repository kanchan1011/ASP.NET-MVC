using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataBindingDemo.Startup))]
namespace DataBindingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
