﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Airlines_Reservation_Management_System.Startup))]
namespace Airlines_Reservation_Management_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
