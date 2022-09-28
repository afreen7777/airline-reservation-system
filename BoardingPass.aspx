<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoardingPass.aspx.cs" Inherits="Airlines_Reservation_Management_System.BoardingPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Boarding Pass</title>
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h2 style="background-color:royalblue;color:white;">Domestic Indian Airlines Reservation:</h2>
    <form id="form1" runat="server">
        <div class="controlMargin">
            <span class="bold">Enter Passenger details here:</span>
            <table border="1">
                <tr>
                    <td>PassengerID (PID)</td><td><asp:TextBox ID="txtPID" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>FlightID</td><td><asp:TextBox ID="txtFID" runat="server"></asp:TextBox></td>

                </tr>
            </table>
            <asp:Button CssClass="btn btn-primary" ID="btnBPass" runat="server" Text ="Get Boarding Pass" OnClick="btnBPass_Click" />
            <br />
            <br />
        </div>
        <div>
           <span class="bold" style="background-color:brown;color:white">Passenger Boarding Pass</span>

            <asp:GridView ID="gvBoardingPass" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
    </form>
</body>
</html>
