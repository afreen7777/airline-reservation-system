<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Airlines_Reservation_Management_System._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

        <h2  style="background-color:darkred; color:white">Welcome to Domestic Airlines Online Reservation. Book your Air Tickets from the comfort of your home location</h2>

    <asp:Image ID="imgFlight" ImageUrl="~/Images/flight2.jpg" runat="server" Width="1250px" Height="500px" />

    <p class="bold">This is an online domestic airline reservation application designed for the academic purpose. Here, the passengers can use this website to book their air tickets within the country connecting major cities. This application has been designed with three tier architecture consisting of Presentation layer, Buisiness Application layer and Data layer.</p>
    
         
</asp:Content>
