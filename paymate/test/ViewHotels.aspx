<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewHotels.aspx.cs" Inherits="test.ViewHotels1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style type="text/css">
        .a {
            width: auto;
            height: auto;
            color: blue;
        }

        .b {
            width: auto;
            padding: 5px;
            height: auto;
            display: table;
            color: blue;
        }

        .tile {
            height: 200px;
            width: 250px;
            float: left;
            margin: 0 5px 0 0;
            padding: 2px;
        }



        .amarelo {
            background: transparent;
        }

        .vermelho {
            background: transparent;
        }

        }

        .azul {
            background: transparent;
        }


        .verde {
            background: transparent;
        }



        .wrap {
            overflow: hidden;
            margin: 10px;
        }
    </style>

<h2 style="text-align: left">Hotel Reservations  </h2>
    <center>
		 <div class="a">
	<div class="b">          
		<div class="tile amarelo bank">
<a  href="javascript:;">
	<img src="assets/img/kingsbury-hotel.jpg"  width="100" height="100" <%--style="width:310px;height:310px;"--%> />
	<br />

  </a>
		</div>

		<div class="tile vermelho fund">
<a  href="javascript:;">
	<img src="assets/img/hilton.png" width="100" height="100"<%--style="width:310px;height:310px;"--%>/>
	<br />
	
  </a >
		</div>
		<div class="tile azul hotel">
<a  href="javascript:;">
   
<img src="assets/img/red.png" width="100" height="100"<%--style="width:310px;height:310px;"--%>/><br />
	
	
</a></div>
		
	
	   <div class="tile  verde phone">
<a  href="javascript:;">
	<img src="assets/img/shang.png" width="100" height="100"<%--style="width:310px;height:310px;"--%>/><br /> 

  </a>
	  </div>
		<br/>
	   <div class="tile azul electricity">
	</div>       
</div>
	  </center>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
