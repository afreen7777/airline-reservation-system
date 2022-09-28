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
    public partial class AddFlight : System.Web.UI.Page
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

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtOrigin.Text = "";
            txtDestination.Text = "";
            txtPrice.Text = "";
            txtDeparture.Text = "";
            txtArrival.Text = "";
            txtStatus.Text = "";
            txtSeats.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (sqlCmd = new SqlCommand())
            {
                qryString = "Insert Into Flights (FlightID, FlightName, Origin, Destination, Price, DepTime, ArrTime, Status, MaxSeats) Values ('" + int.Parse(txtID.Text) + "','" + txtName.Text + "','" + txtOrigin.Text + "','" +txtDestination.Text +"','" +double.Parse(txtPrice.Text) + "','" + txtDeparture.Text + "','" + txtArrival.Text +"','"+ txtStatus.Text +"','"+txtSeats.Text +"')";


                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;

                sqlCon.Open();
                int count = sqlCmd.ExecuteNonQuery();
                if (count > 0)
                {
                    lblUpdate.Text = "Flight is added successfully!";
                }
                else
                {
                    lblUpdate.Text = "Unable to add the Flight";
                }

                sqlCon.Close();
            }
        }
    }
}