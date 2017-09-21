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
                <font style="font: bold; font-size: large;">Reservation Date</font>&nbsp;&nbsp;
                <input type="date" id="reservationdate" runat="server" style="color: black;" />
                <br />
                <br />
                <p style="float: left; font-size: larger;" class="label">

                    <br />
                    Enter room number
                </p>
                <input type="number" id="roomnumber" runat="server" style="width: 50px; height: 50px; color: black;" />
                &nbsp;<asp:Button ID="reserv" runat="server" Text="Reserve" CssClass="btn btn-default" OnClick="reserv_Click" />
                <br />
                <br />
                <br />
                <asp:Label ID="selectdate" BackColor="#ccff33" runat="server" Text="Please select a date" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="invaliddate" BackColor="#ccff33" runat="server" Text="Date cannot be a past date or the current date " ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="roombooked" BackColor="#ccff33" runat="server" Text="Room already booked for the selected date " ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="noroomno" BackColor="#ccff33" runat="server" Text="Enter a room number" ForeColor="#ff3300" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="roomavailable" BackColor="#ccff33" runat="server" Text="Room Available for booking " ForeColor="#00cc00" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <br/>
                <asp:Button ID="pay" runat="server" Text="Pay" CssClass="btn btn-default btn-group-lg" OnClick="pay_Click"/>
                <br/>
                <asp:Label ID="verifypay" BackColor="#ccff33" runat="server" Text="Verifying Payment " ForeColor="#00cc00" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                 <asp:Label ID="insufficient" BackColor="#ccff33" runat="server" Text="Insufficient Bank Ballance " ForeColor="red" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="reserved" BackColor="#ccff33" runat="server" Text="Room Reserved Successfully " ForeColor="#00cc00" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                <asp:Label ID="Invalidroomno" BackColor="#ccff33" runat="server" Text="Invalid Room Number " ForeColor="red" Font-Bold="true" Font-Size="X-Large"></asp:Label>
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
