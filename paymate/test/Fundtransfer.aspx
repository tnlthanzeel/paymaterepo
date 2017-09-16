<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Fundtransfer.aspx.cs" Inherits="test.Fundtransfer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
        <h2 style="text-align: left">Fund Transfer</h2>
        <h4>Transfer to account number </h4>
        <center>
    <asp:TextBox ID="AccountNo" CssClass="form-control input-md" Width="200"  runat="server"></asp:TextBox>
            <asp:Label ID="invalidaccno" runat="server" Text="Inavlid Accout Number" ForeColor="#ff3300"></asp:Label>
            <asp:Label ID="lowbalance" runat="server" Text="Insufficient Bank balance" ForeColor="#ff3300"></asp:Label>
            <br/>
    <h4>Amount</h4>
    <asp:TextBox ID="Amount" CssClass="form-control input-md" Width="200" runat="server"></asp:TextBox><br /><br />
     <asp:Button ID="Transfer" CssClass="btn btn-success" Style="width: auto;" runat="server" Text="Transfer" ForeColor="#000000" OnClick="Transfer_Click"/>
            <br /><hr/>
            <asp:Label ID="transfersuccess" BackColor="#cccc00" runat="server" Text="Fund Transferred Successfully" ForeColor="#009933" Font-Bold="true" Font-Size="X-Large"></asp:Label>
       <asp:Label ID="accnoempty" BackColor="#ccff33" runat="server" Text="Invalid Account Number Or Amount" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>

    </center>
    </form>

</asp:Content>


