<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Bankbalance.aspx.cs" Inherits="test.Bankbalance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="text-align: left">Bank Balance  </h2>

    <center>
        <table style="text-align:right;font-size:large;height:150px" >
            <tr >
               <td> Customer ID</td>
                <td> &emsp;&emsp;<asp:Label ID="cusidd" runat="server" ForeColor="#0066ff" Font-Size="XX-Large"></asp:Label></td>
            </tr>
            <tr>
               <td>Account Number</td>
                <td> &emsp;&emsp;<asp:Label ID="accountno" runat="server" ForeColor="#0066ff" Font-Size="XX-Large"></asp:Label></td>
            </tr>
            <tr>
               <td>Balance</td>
                <td> &emsp;&emsp;<asp:Label ID="balance" runat="server" ForeColor="#ff0000" Font-Size="XX-Large"></asp:Label></td>
            </tr>
        </table>
    </center>
</asp:Content>
