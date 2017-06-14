<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="test.login" %>

<!DOCTYPE html>
<html lang="en">

	<head>

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
				width: 288px
			}
		</style>
</head>

	<body>

		<!-- Top content -->
		<div class="top-content">
			
			<div class="inner-bg">
				<div class="container">
					<div class="row">
						<div class="col-sm-8 col-sm-offset-2 text">
							<h1><strong>Welcome to PAYmate</strong> </h1>
							<div class="description">
								<p class="fa-paragraph">
									Pay your Bills and Transact with a Click
								</p>
							</div>
						</div>
					</div>
					<div class="row">
						<div class="col-sm-6 col-sm-offset-3 form-box">
							<div class="form-top">
								<div class="form-top-left">
									<h3>Login to our PAYmate</h3>
									<p>Enter your username and password to log on:</p>
								</div>
								<div class="form-top-right">
									<i class="fa fa-lock"></i>
								</div>
							</div>
							<div class="form-bottom">
								<form role="form"  method="post" class="login-form" runat="server">
									<div class="form-group">
										
										 <label for="inputEmail" class="control-label">Email Adress</label>
										<input type="email" style="color: black; font-size:22px; " class="form-control" id="inputEmail" runat="server" placeholder="paymate@example.com"  required/>
									</div>
									<div class="form-group">
										<label class="login-form" for="password" >Password</label><br/>
										<input type="password"  class="form-password form-control"  id="password" runat="server" required/>
									</div>
								<center>	<asp:Label ID="loginerror"  runat="server" Text="Incorrect user name or password " ForeColor="red" ></asp:Label><br/></center>
								<table>
									<tr>
									
									<td class="auto-style1"><asp:Button ID="btnlog" runat="server" Text="Sign in" CssClass="btn btn-success"  Width="212px" OnClick="btnlog_Click" /></td>
									<td> <a href="register.aspx"><input type="button" value="Register" Class="btn btn-primary" style="width: 229px" /></a></td>
									</tr>
								</table>
								</form>
							</div>
						</div>
					</div>
					
				</div>
			</div>
			
		</div>


		<!-- Javascript -->
		<script src="assets/js/jquery-1.11.1.min.js"></script>
		<script src="assets/bootstrap/js/bootstrap.min.js"></script>
		<script src="assets/js/jquery.backstretch.min.js"></script>
		<script src="assets/js/scripts.js"></script>
		
		<!--[if lt IE 10]>
			<script src="assets/js/placeholder.js"></script>
		<![endif]-->

	</body>

</html>
