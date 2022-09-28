<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFlight.aspx.cs" Inherits="Airlines_Reservation_Management_System.AddFlight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table border="1">
        <tr>
            <td>FlightID:</td><td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Flight Name:</td><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Origin:</td><td><asp:TextBox ID="txtOrigin" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Destination:</td><td><asp:TextBox ID="txtDestination" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Departure Time(HH:MM)</td><td><asp:TextBox ID="txtDeparture" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Arrival Time(HH:MM)</td><td><asp:TextBox ID="txtArrival" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Price:</td><td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
        </tr>
           <tr>
            <td>Status:</td><td><asp:TextBox ID="txtStatus" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Max Seats:</td><td><asp:TextBox ID="txtSeats" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Button CssClass="btn btn-primary" ID="btnAdd" runat="server" Text="Add Flight" OnClick="btnAdd_Click" /></td>
            <td><asp:Button CssClass="btn btn-primary" ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="lblUpdate" runat="server"></asp:Label>
</asp:Content>
