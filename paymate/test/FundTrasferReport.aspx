﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FundTrasferReport.aspx.cs" Inherits="test.FundTrasferReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

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
<body>
    <form id="form1" runat="server">
     <div style="float:right"><a href="home.aspx"><input type="button" value="Back" class="btn btn-group-lg btn-default"/></a></div>
        <h1>PAYmate Reporting Services</h1>
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableCdn="true"></asp:ScriptManager>
       
        
            &nbsp;From
            <input type="date" id="fromdate" runat="server" />
            &nbsp;&nbsp;To&nbsp;<input type="date" id="todate" runat="server" />&nbsp;&nbsp;  
            <asp:Button ID="genfundtransferrep" runat="server" Text="Generate" OnClick="genfundtransferrep_Click"  CssClass="btn btn-primary btn-group-lg"/>

        
        <br />
        <br />
        <rsweb:ReportViewer ID="fundtrasnferreport" runat="server" Height="422px" Width="1288px"></rsweb:ReportViewer>

        <script type="text/javascript"></script>

    </form>
</body>
</html>
