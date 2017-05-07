using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImportExcelToTableMVC.Startup))]
namespace ImportExcelToTableMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
