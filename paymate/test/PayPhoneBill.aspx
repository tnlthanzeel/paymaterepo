﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PayPhoneBill.aspx.cs" Inherits="test.PayPhoneBill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">  
       Your Phone Number Is <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <br /><br />
    Bill Amount Is <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Pay Telephone Bill"></asp:Label> <br /><br />
    Enter Payment Amount <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="Button1" runat="server" Text="Pay" EnableTheming="False" ForeColor="#333333" />
        </form>




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>