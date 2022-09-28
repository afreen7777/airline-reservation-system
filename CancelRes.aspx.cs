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
    public partial class CancelRes : System.Web.UI.Page
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

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            using (sqlCmd = new SqlCommand())
            {
                qryString = "Delete Passengers Where (PID = " + txtPID.Text + " AND Name = '" + txtName.Text + "') AND (FlightID = " + txtFID.Text + " AND Email = '" + txtEmail.Text + "')";

                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;

                sqlCon.Open();

                int count = sqlCmd.ExecuteNonQuery();

                if(count == 1)
                {
                    lblMsg.Text = "Flight ticket booking cancelled successfully";
                }
                else
                {
                    lblMsg.Text = "Enter the passenger & flight details correctly and try again";
                }

                sqlCon.Close();
            }
        }
    }
}