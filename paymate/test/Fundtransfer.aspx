<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Fundtransfer.aspx.cs" Inherits="test.Fundtransfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form runat="server"><h2 style="text-align:left">Fund Transfer</h2>
<h4>Transfer to account number </h4>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <h4>Amount</h4>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
     <asp:Button ID="Button1" runat="server" Text="Transfer" ForeColor="#999966" />
    </form>
   
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
