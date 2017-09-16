<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="test.home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



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


    <h2 style="text-align: left">Home  </h2>
    <center>
		 <div class="a">
	<div class="b">          
		<div class="tile amarelo bank">
<a  href="Bankbalance.aspx">
	<img src="https://www.bankatfirstnational.com/8BASE/media/images/base/icon-checking.png"  width="100" height="100" <%--style="width:310px;height:310px;"--%> />
	<br />
	View Bank Balance
  </a>
		</div>

		<div class="tile vermelho fund">
<a  href="Fundtransfer.aspx">
	<img src="https://cdn3.iconfinder.com/data/icons/personal-business-finance-1/380/Funds_Transfer-512.png" width="100" height="100"/>
	<br />
	Fund Transfer
  </a href="javascript:;">
		</div>
		<div class="tile azul hotel">
<a  href="javascript:;">
   
<img src="assets/img/hotel-icon-blue.jpg" width="100" height="100"/><br />
	
	Hotel Reservations
</a></div>
		
	
	   <div class="tile  verde phone">
<a  href="javascript:;">
	<img src="https://media.acecash.com/~/media/ACE/Images/Icons/prod-bp.ashx?h=100&w=100&la=en&hash=5FCC59CEF5CFBE1874021FFB16D2F43B89BA9DE4" width="100" height="100"/><br /> View Phone Bill

  </a>
	  </div>
		<br/>
	   <div class="tile azul electricity">
<a  href="javascript:;">
	<img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIhO8fj3Tf3-SsZIBsxA7UchuWIcBzXOw_5GyX6lDUQHNc8nDHcQ" width="100" height="100"/><br />
	View Electricity Bill
  </a>
		</div>     
	<div class="b">          
		
		</div>
			  
		<div class="tile amarelo water">
<a  href="javascript:;">
	<img src="https://www.dekalbcountyga.gov/sites/default/files/quick-links/quick-icon-6.png" width="100" height="100"/><br />
	View Water Bill
  </a>
		</div>
	<div class="tile verde insuarance">
<a  href="javascript:;">
	<img src="http://skywoodrecovery.com/wp-content/uploads/2016/02/health-insurance-icon-300x300.jpg" width="100" height="100"/><br />
	Insuarance premium
  </a>
	   </div>
	</div>       
</div>
	  </center>

</asp:Content>
