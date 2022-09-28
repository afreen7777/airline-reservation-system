<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Airlines_Reservation_Management_System.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="~/Content/Site.css" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <h4>Domestic Indian Airlines Reservation </h4>
    
    <div class="controlMargin">
         <asp:GridView runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="254px" Width="988px" ID="gvFlights">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    </div>
   
    <div class="controlMargin">
          <asp:Button CssClass="btn btn-primary" runat="server" text="Show Flights" ID="btnRefresh" OnClick="btnRefresh_Click"/>
    </div>

    <hr />
    <h4>Passenger Details:</h4>
    <div class="controlMargin">
        <asp:GridView ID="gvPassengers" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="673px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    <div class="controlMargin">
         <asp:Button CssClass="btn btn-primary" ID="btnPassengers" runat="server" Text="Show Passengers" OnClick="btnPassengers_Click"/>
    </div>
   
    <hr />

    <h4>Only Admin can add, modify, and delete flights here</h4>

    <div class="controlMargin">
        <h4><asp:LinkButton runat="server" PostBackUrl="~/AddFlight.aspx">Add Flight</asp:LinkButton></h4>
    </div>
     <div class="controlMargin">
       <h4><asp:LinkButton  runat="server" ID="btnEdit" PostBackUrl="~/EditFlight.aspx" >Edit Flight</asp:LinkButton></h4>
    </div>
    <div class="controlMargin">
       <h4><asp:LinkButton  runat="server" ID="btnDelete" PostBackUrl="~/DeleteFlight.aspx" >Delete Flight</asp:LinkButton></h4>
    </div>
   
</asp:Content>

