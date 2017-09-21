<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PayPhoneBill.aspx.cs" Inherits="test.PayPhoneBill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="text-align: left">Pay Telephone Bill</h2>

    <form runat="server">
        <center style="font-size: large">
       Your Phone Number Is <asp:Label ID="phonenumberlabel" runat="server" Text="Label" BackColor="#cccc00" ForeColor="#009933" Font-Bold="true" Font-Size="X-Large"></asp:Label> <br /><br />
    Bill Amount Is <asp:Label ID="phonebillammount" runat="server" Text="Label" BackColor="#cccc00" ForeColor="#009933" Font-Bold="true" Font-Size="X-Large"></asp:Label> <br /><br />
    Enter Payment Amount <asp:TextBox ID="PaymantAmount" CssClass="form-control input-md" Width="200" runat="server" required="" type="number"></asp:TextBox><br /><br />
    <asp:Button ID="paybill" runat="server" Text="Pay"  CssClass="btn btn-primary" OnClick="paybill_Click" />
            <br/>
            <br/>
             <asp:Label ID="invalidammount"  BackColor="#ccff33" runat="server" Text="Invalid Amount" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="insufficentammount"  BackColor="#ccff33" runat="server" Text="Insufficient Bank Balance" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="paymentsuccessfull"  BackColor="#ccff33" runat="server" Text="Phone Bill Paid Successfully" ForeColor="#009900" Font-Bold="true" Font-Size="X-Large"></asp:Label>
    </form>
    </center> 




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
