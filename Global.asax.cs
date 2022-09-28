using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Airlines_Reservation_Management_System
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["Total_Seats_AirExpress"] = 0;
            Application["Total_Seats_AirCapital"] = 0;
            Application["Total_Seats_AirDeccan"] = 0;
            Application["Total_Seats_AirSouth"] = 0;
            Application["Total_Seats_AirEastWest"] = 0;
            Application["Total_Seats_AirCoastal"] = 0;
           
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        void Session_Start(object sender, EventArgs e)
        {

        }

        void Session_End(object sender, EventArgs e)
        {

        }
    }
}