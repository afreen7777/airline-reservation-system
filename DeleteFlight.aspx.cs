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
    public partial class DeleteFlight : System.Web.UI.Page
    {
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlCon = new SqlConnection(conString);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (sqlCmd = new SqlCommand())
            {
                qryString = "Delete Flights Where FlightID = " + int.Parse(txtID.Text);
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;

                sqlCon.Open();

                int count = sqlCmd.ExecuteNonQuery();

                if (count == 1)
                    lblDelete.Text = "Flight deleted successfully";
                else
                    lblDelete.Text = "Flight is not deleted";

                sqlCon.Close();
            }
        }
    }
}