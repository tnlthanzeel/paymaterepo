<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="test.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Registration</title>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
   <div class="container">
	<div class="row">
	<form class="form-horizontal" runat="server">
<fieldset>

<!-- Form Name -->
<legend>Customer Registration Form</legend>

<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="emailId" >User Email</label>  
  <div class="col-md-6">
  <input id="emailId" name="emailId" type="text" runat="server" placeholder="paymate@something.com" class="form-control input-md" required=""/>
	
  </div>
</div>

<!-- Password input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="passwordinput">Password</label>
  <div class="col-md-5">
	<input id="passwordinput" name="passwordinput" type="password" placeholder="" class="form-control input-md" required=""/>
	  </div>
</div>



<!-- Multiple Radios (inline) -->
<div class="form-group">
  <label class="col-md-4 control-label" for="cardtype">Card Type</label>
  <div class="col-md-4"> 
	<label class="radio-inline" for="cardtype-visa">
	  <input type="radio" name="cardtype" id="cardtype-visa" value="Visa" checked="checked"/>
	  Visa
	</label> 
	<label class="radio-inline" for="cardtype-mastro">
	  <input type="radio" name="cardtype" id="cardtype-mastro" value="Mastro"/>
	  Mastro
	</label>
  </div>
</div>


<!-- Text input-->
<div class="form-group">
  <label class="col-md-4 control-label" for="mobilenumber">Mobile Number</label>  
  <div class="col-md-5">
  <input id="mobilenumber" name="mobilenumber" type="text" placeholder="Mobile Number" class="form-control input-md" required=""/>
	
  </div>
</div>

<!-- Text input-->



<!-- Button -->
<div class="form-group">
  <label class="col-md-4 control-label" for="submit"></label>
  <div class="col-md-4">
	<asp:Button ID="btnreg" runat="server" Text="Register" CssClass="btn btn-success"  Width="212px" OnClick="btnreg_Click" />
  </div>
</div>

</fieldset>
</form>
	</div>
</div>
</body>
</html>
