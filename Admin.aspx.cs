using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Airlines_Reservation_Management_System
{
    public partial class About : Page
    {
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                sqlCon = new SqlConnection(conString);

            }
        }

        protected void btnPassengers_Click(object sender, EventArgs e)
        {
            qryString = "Select P.PID,P.Name,P.Age,P.Email,P.Mobile,F.FlightID,F.FlightName,P.DateOfFlight from Passengers P INNER JOIN Flights F ON P.FlightID = F.FlightID";
            using (sqlCmd = new SqlCommand())
            {
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;

                sqlCon.Open();

                dr = sqlCmd.ExecuteReader();
                gvPassengers.DataSource = dr;
                gvPassengers.DataBind();

                dr.Close();
                sqlCon.Close();
            }       
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            qryString = "Select * from Flights";
            sqlCmd = new SqlCommand(qryString, sqlCon);

            sqlCon.Open();

            dr = sqlCmd.ExecuteReader();
            gvFlights.DataSource = dr;
            gvFlights.DataBind();

            dr.Close();
            sqlCon.Close();
        }
    }
}