using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCFMELLO.CursoMvc.UI.Mvc.Startup))]
namespace PCFMELLO.CursoMvc.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
