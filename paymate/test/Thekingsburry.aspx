<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Thekingsburry.aspx.cs" Inherits="test.Thekingsburry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <h2 style="text-align: left;">The KingsBury</h2>
        <br />
        <div style="float: left; padding-left: 2em;">
            <div style="align-content: center;">
                <a href="Viewreservations.aspx">
                    <input type="button" value="View Reservations" class="btn btn-success" /></a>

                <br />
                <br />
                <br />
                <br />
                <br />
                <p class="label label-primary" style="font-size: large;">New Reservation</p>
                <br />
                <br />
                <p style="float: left; font-size: larger;" class="label">
                    <br/>Enter room number
                </p>
                <input type="number" id="roomnumber" runat="server" style="width: 50px; height: 50px" />
                &nbsp;<input type="button" value="Reserve" class="btn btn-default"  />
            </div>

        </div>
        <div style="float: right; padding-right: 4em;">
            <asp:GridView ID="roomstable" runat="server" CssClass="table table-hover" CellPadding="4" ForeColor="#333333" GridLines="None" Width="500">
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
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
