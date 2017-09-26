<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Viewreservations.aspx.cs" Inherits="test.Viewreservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <h2 style="text-align: left;">View and Cancel Reservations</h2>
        <div style="float: left; padding-left: 2em;">
            <div style="align-content: center;">
                <br />
                <br />
                <p class="label label-primary" style="font-size: large;">Cancel Reservation</p>
                <br />
                <br />

                <p style="float: left; font-size: larger;" class="label">

                    <br />
                    Enter Id
                </p>
                <input type="number" id="cancelid" runat="server" style="width: 50px; height: 50px; color: black;" />
                &nbsp;<asp:Button ID="cancel" runat="server" Text="Cancel Reservation" CssClass="btn btn-default" OnClick="cancel_Click" />
                <br />
                <br />
                <br />


            </div>
        </div>
        <br />
        <div style="float: right; padding-right: 4em;">
            <asp:GridView ID="reservationstable" runat="server" CssClass="table table-hover" CellPadding="4" ForeColor="#333333" GridLines="None" Width="500">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="noid" BackColor="#ccff33" runat="server" Text="Enter an ID to cancel reservation" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="cancelsuccess" BackColor="#ccff33" runat="server" Text="Reservation Canceled Successfully " ForeColor="#00cc00" Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="invalidid" BackColor="#ccff33" runat="server" Text="Invalid ID" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>

    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
