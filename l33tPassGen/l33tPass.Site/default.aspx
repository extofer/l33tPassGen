<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="l33tPass.Site._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">

	<title>l33t p@ssword generat0r</title>
	<meta name="description" content="">
	<meta name="author" content="">
	<meta name="viewport" content="width=device-width">
	<link rel="stylesheet" href="css/bootstrap.min.css">
	<style>
	body {
	  padding-top: 60px;
	  padding-bottom: 40px;
	}
	</style>
	<link rel="stylesheet" href="css/bootstrap-responsive.min.css">
	<link rel="stylesheet" href="css/style.css">
	<script src="js/libs/modernizr-2.5.3-respond-1.1.0.min.js" type="text/javascript"></script>
</head>
<body>
        <div class="navbar navbar-fixed-top">
      <div class="navbar-inner">
        <div class="container">
          <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </a>
          <a class="brand" href="#">l33t p@ssword generat0r</a>
          <div class="nav-collapse">
            <ul class="nav">
              <li class="active"><a href="#">Home</a></li>
<%--              <li><a href="#about">About</a></li>
              <li><a href="#contact">Contact</a></li>--%>
            </ul>
          </div><!--/.nav-collapse -->
        </div>
      </div>
    </div>

    <div class="container">

    <form id="form1" runat="server">
    <div>

        <div> 
        <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
        <br />
            <asp:LinkButton ID="btnGenerate" runat="server" onclick="LinkButton1_Click">Generate</asp:LinkButton>
        </div>   
        <div>
        <textarea id="richTextBox1" cols="20" name="S1" rows="2" runat="server"></textarea></div>
        </div>

        
           

    </form>
   </div>
</body>
</html>
