<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="test.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <script  type="text/javascript">

        var col = 0;
        function changeMarqueeColor() {
            if (col == 0) {
                document.getElementById("thakan").style.color = "red";
                col = 1;
            }
            else {
                document.getElementById("thakan").style.color = "blue";
                col = 0;
            }
        }
        setInterval(changeMarqueeColor, 500)

        </script>


    <div style="text-align: center">

        <center><h1>-Our Mission-</h1></center>
        <br />

        <div class="alert-success">
            <br />
            <div class="btn btn-default">to make people’s lives easier and less stressful</div>
            <br />
            <br />
            <hr />
            <center style="font: bold; font-size: large"><h1 style="color:firebrick;">About</h1></center> <hr/> <br /> <br />
               
        <table >
            <tr>
                <td style="width:700px;text-align:justify;line-height:30px">
    Paying bills and transferring cash have been a common task for the common man in the modern world. Which is for some,
not an easy task with the busy schedule they bare. PAYmate is an Application which is mainly designed
to meet Every day needs of a user which includes many of the selected quite important tasks like cash
transferring, to make bill payments, hotel reservations, and even to pay insurance premium which can be
done from anywhere just by installing PAYmate in a Laptop, smartphone or any kind of smart device.
Anyone with a Visa Debit card is eligible to use it.
                    </td>
                </tr>
            </table>

<br />To do real time transactions<span style="color:crimson"> ‘on the go’</span>.<br /><br /><br />
<div class="list-group;">
<ul style="text-align:left;color:brown;" id="thakan">
<li> Bill Payment </li>
<li> View, Reserve and cancel hotel Rooms</li>
<li> Pay Insurance Premium</li>
<li> Bank to Bank fund transferring</li>
<li> Check Bank balance</li>
<li> View transaction log </li>
    </ul>
    </div> <br/>
        </div>

    </div>
</asp:Content>
