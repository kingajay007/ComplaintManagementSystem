using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Complaint_Management_System.Startup))]
namespace Complaint_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
