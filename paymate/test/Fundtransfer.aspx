<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Fundtransfer.aspx.cs" Inherits="test.Fundtransfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form runat="server"><h2 style="text-align:left">Fund Transfer</h2>
<h4>Transfer to account number </h4>
   <center>
    <asp:TextBox ID="AccountNo" CssClass="form-control input-md" Width="200"  runat="server"></asp:TextBox>
    <h4>Amount</h4>
    <asp:TextBox ID="Amount" CssClass="form-control input-md" Width="200" runat="server"></asp:TextBox><br /><br />
    </center>
       </form>
   
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
