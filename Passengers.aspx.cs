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
    public partial class Contact : Page
    {
        string conString, qryString;
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlCon = new SqlConnection(conString);

            if (!Page.IsPostBack)
            {
                using (sqlCmd = new SqlCommand())
                {
                    sqlCon.Open();
                    qryString = "Select distinct FlightName from Flights";
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = qryString;
                    sqlCmd.Connection = sqlCon;

                    dr = sqlCmd.ExecuteReader();
                    ddlFlightsList.DataSource = dr;
                    ddlFlightsList.DataTextField = "FlightName";
                    ddlFlightsList.DataBind();

                    dr.Close();
                    sqlCon.Close();
                    
                }                

            }
        }

        protected void btnCheckAv_Click(object sender, EventArgs e)
        {
            Session["FlightID"] = int.Parse(txtFID.Text);

           if(int.Parse(Session["FlightID"].ToString()) == 1001)
            {
                if ((int)Application["Total_Seats_AirExpress"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
           else if (int.Parse(Session["FlightID"].ToString()) == 1002)
            {
                if ((int)Application["Total_Seats_AirExpress"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1003)
            {
                if ((int)Application["Total_Seats_AirCapital"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1004)
            {
                if ((int)Application["Total_Seats_AirCapital"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1005)
            {
                if ((int)Application["Total_Seats_AirDeccan"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1006)
            {
                if ((int)Application["Total_Seats_AirDeccan"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1007)
            {
                if ((int)Application["Total_Seats_AirSouth"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1008)
            {
                if ((int)Application["Total_Seats_AirSouth"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1009)
            {
                if ((int)Application["Total_Seats_AirEastWest"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1010)
            {
                if ((int)Application["Total_Seats_AirEastWest"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1011)
            {
                if ((int)Application["Total_Seats_AirCoastal"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1012)
            {
                if ((int)Application["Total_Seats_AirCoastal"] < 100)
                {
                    lblStatus.Text = "Flight Ticket is Available";
                }
                else
                {
                    lblStatus.Text = "Flight Ticket Not Available";
                }
            }

        }

        protected void btnBookT_Click(object sender, EventArgs e)
        {
            Session["FlightID"] = int.Parse(txtFID.Text);

            if (int.Parse(Session["FlightID"].ToString()) == 1001)
            {
                if ((int)Application["Total_Seats_AirExpress"] < 100)
                {
                    Application["Total_Seats_AirExpress"] = (int)Application["Total_Seats_AirExpress"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }

            else if (int.Parse(Session["FlightID"].ToString()) == 1002)
            {
                if ((int)Application["Total_Seats_AirExpress"] < 100)
                {
                    Application["Total_Seats_AirExpress"] = (int)Application["Total_Seats_AirExpress"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1003)
            {
                if ((int)Application["Total_Seats_AirCapital"] < 100)
                {
                    Application["Total_Seats_AirCapital"] = (int)Application["Total_Seats_AirCapital"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1004)
            {
                if ((int)Application["Total_Seats_AirCapital"] < 100)
                {
                    Application["Total_Seats_AirCapital"] = (int)Application["Total_Seats_AirCapital"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1005)
            {
                if ((int)Application["Total_Seats_AirDeccan"] < 100)
                {
                    Application["Total_Seats_AirDeccan"] = (int)Application["Total_Seats_AirDeccan"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1006)
            {
                if ((int)Application["Total_Seats_AirDeccan"] < 100)
                {
                    Application["Total_Seats_AirDeccan"] = (int)Application["Total_Seats_AirDeccan"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1007)
            {
                if ((int)Application["Total_Seats_AirSouth"] < 100)
                {
                    Application["Total_Seats_AirSouth"] = (int)Application["Total_Seats_AirSouth"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1008)
            {
                if ((int)Application["Total_Seats_AirSouth"] < 100)
                {
                    Application["Total_Seats_AirSouth"] = (int)Application["Total_Seats_AirSouth"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1009)
            {
                if ((int)Application["Total_Seats_AirEastWest"] < 100)
                {
                    Application["Total_Seats_AirEastWest"] = (int)Application["Total_Seats_AirEastWest"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1010)
            {
                if ((int)Application["Total_Seats_AirEastWest"] < 100)
                {
                    Application["Total_Seats_AirEastWest"] = (int)Application["Total_Seats_AirEastWest"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1011)
            {
                if ((int)Application["Total_Seats_AirCoastal"] < 100)
                {
                    Application["Total_Seats_AirCoastal"] = (int)Application["Total_Seats_AirCoastal"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
            else if (int.Parse(Session["FlightID"].ToString()) == 1012)
            {
                if ((int)Application["Total_Seats_AirCoastal"] < 100)
                {
                    Application["Total_Seats_AirCoastal"] = (int)Application["Total_Seats_AirCoastal"] + 1;

                    InsertPassengers();
                }

                else
                {
                    lblStatus.Text = "Try with Another Flight as this flight reservation is full";
                }
            }
        }

        public void InsertPassengers()
        {
            using (sqlCmd = new SqlCommand())
            {            
                qryString = "Insert Into Passengers Values('" + txtName.Text + "'," + int.Parse(txtAge.Text) + ",'" + txtEmail.Text + "','" + txtMobile.Text + "'," + int.Parse(txtFID.Text) +",'"+calFlight.SelectedDate.ToShortDateString() +"')";


                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = qryString;
                sqlCon.Open();

                int count = sqlCmd.ExecuteNonQuery();
                if (count == 1)
                {
                    lblStatus.Text = "Flight Ticket Booked Successfully\n";

                    qryString = "Select PID from Passengers Where (Name = '"+txtName.Text+"' AND Email ='" +txtEmail.Text +"') AND (DateOfFlight = '"+calFlight.SelectedDate.ToShortDateString() +"' AND FlightID = "+int.Parse(txtFID.Text)+")";

                    sqlCmd = new SqlCommand(qryString, sqlCon);
                    var PID = sqlCmd.ExecuteScalar();

                    Session["PID"] = int.Parse(PID.ToString());
                    Session["FID"] = txtFID.Text;

                    lblStatus.Text += "Your Passenger ID: " + Session["PID"] + "\n Flight ID:" + Session["FID"];
                }
                else
                {
                    lblStatus.Text = "Something went wrong, try after some time";
                }

                sqlCon.Close();
            }
        }

        protected void calFlight_SelectionChanged(object sender, EventArgs e)
        {
            lblDate.Text = "You have selected the date of flight: " + calFlight.SelectedDate.ToLongDateString();
        }


        protected void ddlFlightsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                using(sqlCmd = new SqlCommand())
                {
                    qryString = "Select FlightId,FlightName,Origin,Destination,Price,DepTime,ArrTime,Status from Flights Where FlightName = '"+ddlFlightsList.SelectedItem.ToString()+"'";

                    sqlCmd.CommandText = qryString;
                    sqlCmd.Connection = sqlCon;

                    sqlCon.Open();
                    dr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);

                    gvFlightDetails.DataSource = dr;
                    gvFlightDetails.DataBind();

                    dr.Close();

                }
            }
        }
    }
}