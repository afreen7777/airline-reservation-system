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
    public partial class EditFlight : System.Web.UI.Page
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

        protected void btnShowDetails_Click(object sender, EventArgs e)
        {
            using (sqlCmd = new SqlCommand())
            {
                qryString = "Select FlightID, FlightName, Origin, Destination, Price, DepTime, ArrTime, Status, MaxSeats from Flights Where FlightID =" + int.Parse(txtFID.Text);
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;

                sqlCon.Open();
                dr = sqlCmd.ExecuteReader();

                dr.Read();

                txtID.Text = dr["FlightID"].ToString();
                txtName.Text = dr["FlightName"].ToString();
                txtOrigin.Text = dr["Origin"].ToString();
                txtDestination.Text = dr["Destination"].ToString();
                txtPrice.Text = dr["Price"].ToString();
                txtDeparture.Text = dr["DepTime"].ToString();
                txtArrival.Text = dr["ArrTime"].ToString();
                txtStatus.Text = dr["Status"].ToString();
                txtSeats.Text = dr["MaxSeats"].ToString();

                dr.Close();
                sqlCon.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (sqlCmd = new SqlCommand())
            {
                qryString = "Update Flights Set FlightName = '" + txtName.Text + "', Origin = '" + txtOrigin.Text + "', Destination = '" + txtDestination.Text + "', Price = '" + txtPrice.Text + "', DepTime = '" + txtDeparture.Text + "', ArrTime = '" + txtArrival.Text + "', Status = '" + txtStatus.Text +"', MaxSeats = "+int.Parse(txtSeats.Text) + " Where FlightID = " + int.Parse(txtID.Text);

                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;

                sqlCon.Open();

                int count = sqlCmd.ExecuteNonQuery();

                if (count == 1)
                    lblUpdate.Text = "Flight details updated successfully";
                else
                    lblUpdate.Text = "Flight details not updated";

                sqlCon.Close();
  
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
    }
}