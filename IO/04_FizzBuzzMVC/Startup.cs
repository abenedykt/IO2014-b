﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_04_FizzBuzzMVC.Startup))]
namespace _04_FizzBuzzMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
