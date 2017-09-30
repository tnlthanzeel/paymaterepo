<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="publicabout.aspx.cs" Inherits="test.publicabout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>PAYmate</title>

    <!-- CSS -->
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,100,300,500">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="assets/css/form-elements.css">
    <link rel="stylesheet" href="assets/css/style.css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
			<script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
			<script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
		<![endif]-->

    <!-- Favicon and touch icons -->
    <link rel="shortcut icon" href="assets/ico/pm.png">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/144.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/114.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/72.png">
    <link rel="apple-touch-icon-precomposed" href="assets/ico/57.png">

    <meta name="keyword" content="payment, payment app, money transfer" />
    <style type="text/css">
        .auto-style1 {
            width: 288px;
        }
    </style>
</head>
<body>
    <div style="text-align: left">
        <span class="fa fa-arrow-circle-left" style="padding-left: 1em;">
            <a href="login.aspx">Back</a>
        </span>
    </div>
    <script type="text/javascript">

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
            <center style="font: bold; font-size: large"><h1 style="color:firebrick;">About</h1><center> <hr/> <br /> <br />
               
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

</body>
</html>
