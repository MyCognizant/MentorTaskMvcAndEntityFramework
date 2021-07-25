using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MentorTasks.Web.MvcBasics.Startup))]
namespace MentorTasks.Web.MvcBasics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
