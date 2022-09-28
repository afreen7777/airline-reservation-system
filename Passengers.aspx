<%@ Page Title="Guest Passengers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Passengers.aspx.cs" Inherits="Airlines_Reservation_Management_System.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="~/Content/Site.css" />

    <h4><%: Title %></h4>

     <div style="background-color:darkblue; color:white">
        <h4>Welcome <%:User.Identity.Name%> to Domestic Indian Airlines Reservation. Book your Air Tickets from the comfort of your home location</h4>
    </div>

    <div class="controlMargin">
       <span class="bold">Enter Passenger Details Here:</span>
       <table border="1" style="background-color:aqua;color:blue;">
           <tr>
               <td>Name:</td><td><asp:TextBox Id="txtName" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
               <td>Age:</td><td><asp:TextBox Id="txtAge" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
               <td>Email:</td><td><asp:TextBox Id="txtEmail" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
               <td>Mobile:</td><td><asp:TextBox Id="txtMobile" runat="server"></asp:TextBox></td>
           </tr>
       </table>
    </div>
    

    <div class="controlMargin">
       <span class="bold">Select Flight</span>
        <asp:DropDownList Id="ddlFlightsList" runat="server" OnSelectedIndexChanged="ddlFlightsList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
    </div>
   
    <div class="controlMargin">
        <asp:GridView Id="gvFlightDetails" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </div>

    <div class="controlMargin">
        <span class="bold">Enter date of flight:</span>
        <asp:Calendar ID="calFlight" runat="server" OnSelectionChanged="calFlight_SelectionChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
            <DayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
            <TodayDayStyle BackColor="#999999" ForeColor="White" />
        </asp:Calendar>
        <asp:Label ID="lblDate" runat="server"></asp:Label>
    </div>

   
       <div class="controlMargin">
            <span class="bold">Enter Flight ID to book the flight:</span>
           <asp:TextBox Id="txtFID" runat="server"></asp:TextBox>
       </div>

    <div class="controlMargin">
        <asp:Button CssClass="btn btn-primary" ID="btnCheckAv" runat="server" Text="Check Availability" OnClick="btnCheckAv_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button CssClass="btn btn-primary" Id="btnBookT" runat="server" Text="Book Ticket" OnClick="btnBookT_Click" />
        <asp:Label ID="lblStatus" runat="server"></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;

       <asp:Button CssClass="btn btn-primary" ID="btnBPass" runat="server" Text="Get Boarding Pass" PostBackUrl="~/BoardingPass.aspx"></asp:Button>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button CssClass="btn btn-primary" ID="btnCanRes" runat="server" Text="Cancel Reservation" PostBackUrl="~/CancelRes.aspx"></asp:Button>
        
    </div>
    
 
</asp:Content>
