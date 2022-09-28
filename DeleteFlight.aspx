<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteFlight.aspx.cs" Inherits="Airlines_Reservation_Management_System.DeleteFlight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />

    <h4>Enter the FlightID to delete the flight:<asp:TextBox ID="txtID" runat="server"></asp:TextBox></h4>
    <h4><asp:Button CssClass="btn btn-primary" ID="btnDelete" runat="server" Text="Delete Flight" OnClick="btnDelete_Click" /></h4>
    <asp:Label ID="lblDelete" runat="server"></asp:Label>

</asp:Content>
