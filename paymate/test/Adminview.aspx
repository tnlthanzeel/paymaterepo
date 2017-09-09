<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminview.aspx.cs" Inherits="test.Adminview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<link href="~/Content/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

	<!-- Custom Fonts -->
	<link href="~/Content/vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
	<link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
	<link href='https://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'>

	<!-- Plugin CSS -->
	<link href="~/Content/vendor/magnific-popup/magnific-popup.css" rel="stylesheet">

	<!-- Theme CSS -->
	<link href="~/Content/css/creative.min.css" rel="stylesheet">

	<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
	<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
	<!--[if lt IE 9]>
		<script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
		<script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
	<![endif]-->
	<link rel="shortcut icon" href="assets/ico/pm.png" />
	<link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/144.png" />
	<link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/114.png" />
	<link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/72.png" />
	<link rel="apple-touch-icon-precomposed" href="assets/ico/57.png" />
	<title>PAYmate</title>
</head>

<body style="background-image: url(assets/img/adminlogged.png); ">
	<form id="form1" runat="server">
	<div>
	   <a href="login.aspx"><img src="assets/img/backgrounds/logout.png"/></a> Logged in as <asp:Label ID="loggedinas" runat="server" CssClass="text-primary text-uppercase" Font-Bold="true"></asp:Label>
	</div>
	</form>
</body>
</html>
