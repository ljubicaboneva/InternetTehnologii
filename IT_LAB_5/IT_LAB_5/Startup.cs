﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_LAB_5.Startup))]
namespace IT_LAB_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
