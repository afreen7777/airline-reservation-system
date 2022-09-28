<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancelRes.aspx.cs" Inherits="Airlines_Reservation_Management_System.CancelRes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cancelling Reservation</title>
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h2 style="background-color:royalblue;color:white;">Domestic Indian Airlines Reservation:</h2>
        </div>
        <div>
            <span class="bold" style="background-color:brown;color:white">Cancelling Reservation...</span>
        </div>
        <h4>Please enter flight ticket details here:</h4>
        <div class="controlMargin">
            <table border="1" style="background-color:aqua;color:blue;">
                <tr>
                    <td>PID (Passenger ID):</td><td><asp:TextBox ID="txtPID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name:</td><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Email:</td><td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>FlightID:</td><td><asp:TextBox ID="txtFID" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div class="controlMargin">
             <asp:Button CssClass="btn btn-primary" ID="btnCancel" Text="Confirm Cancellation" runat="server" OnClick="btnCancel_Click" />
             <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
        
         
    </form>
</body>
</html>
