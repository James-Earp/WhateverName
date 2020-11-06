using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhateverName.UI.MVC.Startup))]
namespace WhateverName.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
