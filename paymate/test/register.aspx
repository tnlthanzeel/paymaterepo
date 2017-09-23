<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="test.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="shortcut icon" href="assets/ico/pm.png">
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/144.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/114.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/72.png">
    <link rel="apple-touch-icon-precomposed" href="assets/ico/57.png">
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
                        <label class="col-md-4 control-label" for="emailId">Name</label>
                        <div class="col-md-6">
                            <input id="name" name="name" type="text" runat="server" placeholder="Thanzeel" class="form-control input-md" required="" />

                        </div>
                    </div>


                    <div class="form-group">
                        <label class="col-md-4 control-label" for="emailId">User Email</label>
                        <div class="col-md-6">
                            <input id="emailId" name="emailId" type="email" runat="server" placeholder="paymate@something.com" class="form-control input-md" required="" /><asp:Label ID="useravailable" runat="server" Text="This email address is already taken" ForeColor="red"></asp:Label>

                        </div>
                    </div>

                    <!-- Password input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="passwordinput">Password</label>
                        <div class="col-md-5">
                            <input id="passwordinput" name="passwordinput" type="password" placeholder="" class="form-control input-md" required="" runat="server" />
                        </div>
                    </div>



                    <!-- Multiple Radios (inline) -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="cardtype">Card Type</label>
                        <div class="col-md-4">
                            <label class="radio-inline" for="cardtypevisa">
                                <input type="radio" name="cardtype" id="cardtypevisa" value="Visa" required="required" runat="server" />
                                Visa
                            </label>
                            <label class="radio-inline" for="cardtypemastro">
                                <input type="radio" name="cardtype" id="cardtypemastro" value="Mastro" required="required" runat="server" />
                                Mastro
                            </label>
                        </div>
                    </div>


                    <div class="form-group">
                        <label class="col-md-4 control-label" for="emailId">Card Number</label>
                        <div class="col-md-6">
                            <input id="cardno" name="cardno" type="number" runat="server" class="form-control input-md" required="required" />

                        </div>
                    </div>


                    <!-- Text input-->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="mobilenumber">Mobile Number</label>
                        <div class="col-md-5">
                            <input id="mobilenumber" runat="server" name="mobilenumber" type="number" placeholder="0772522552" class="form-control input-md" required="" />

                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-md-4 control-label" for="mobilenumber">Address</label>
                        <div class="col-md-5">
                            <%--<input id="address" name="mobilenumber" type="text" placeholder="Mobile Number" class="form-control input-md" required="" />--%>
                            <textarea id="address" cols="20" rows="2" class="form-control" runat="server"></textarea>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="col-md-4 control-label" for="mobilenumber">NIC Number</label>
                        <div class="col-md-5">
                            <input id="nicnumber" runat="server" name="nicnumber" type="text" placeholder="123456789v" class="form-control input-md" required="" />

                        </div>
                    </div>


                    <!-- Button -->
                    <div class="form-group">
                        <label class="col-md-4 control-label" for="submit"></label>
                        <div class="col-md-4">
                            <asp:Button ID="btnreg" runat="server" Text="Register" CssClass="btn btn-success" Width="212px" OnClick="btnreg_Click" />
                        </div>
                    </div>

                </fieldset>
            </form>
        </div>
    </div>
</body>
</html>
