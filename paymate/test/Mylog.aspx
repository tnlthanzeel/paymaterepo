<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Mylog.aspx.cs" Inherits="test.Mylog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <h2 style="text-align: left">Transaction Log</h2>
        <div style="float: left; font: bold; font-size: larger">
            &nbsp;&nbsp;&nbsp;From&nbsp;<input type="date" id="fromdate" runat="server" style="color: black" />
            &nbsp;&nbsp;&nbsp;  To&nbsp;<input type="date" id="todate" runat="server" style="color: black" />
            <asp:Button ID="processlog" runat="server" Text="Generate" CssClass="btn btn-primary " OnClick="processlog_Click" />

        </div>
        <br />
        <br />
        <center>
    <asp:GridView ID="logtable" runat="server" CssClass="table table-hover" CellPadding="4" ForeColor="#333333" GridLines="None">
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
</asp:GridView></center>
        <asp:Label ID="dateerror" BackColor="#ccff33" runat="server" Text="Please select a valid date range" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
    <asp:Label ID="nodata" BackColor="#ccff33" runat="server" Text=" No records found " ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
         </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
