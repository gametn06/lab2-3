using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab2_3_NguyenHuuThang.Startup))]
namespace Lab2_3_NguyenHuuThang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
