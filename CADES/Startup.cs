﻿using Microsoft.Owin;
using Owin;
using System.Web.Security;

[assembly: OwinStartupAttribute("CADES",typeof(CADES.Startup))]
namespace CADES
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
