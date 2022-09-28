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
    public partial class BoardingPass : System.Web.UI.Page
    {
        string qryString, conString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlCon = new SqlConnection(conString);

        }

        protected void btnBPass_Click(object sender, EventArgs e)
        {
           
                using (sqlCmd = new SqlCommand())
                {
                    qryString = "Select P.PId, P.Name, P.Age, P.DateOfFlight, F.FlightId, F.FlightName, F.Origin, F.Destination, F.DepTime, F.ArrTime from Flights F INNER JOIN Passengers P ON P.FlightId = F.FlightId Where (P.PId = " + int.Parse(txtPID.Text) + " AND F.FlightID = " + int.Parse(txtFID.Text) + ")";

                    sqlCmd.CommandText = qryString;
                    sqlCmd.Connection = sqlCon;

                    sqlCon.Open();
                    dr = sqlCmd.ExecuteReader();
                    gvBoardingPass.DataSource = dr;
                    gvBoardingPass.DataBind();

                    sqlCon.Close();
                }
        }

       
    }
}