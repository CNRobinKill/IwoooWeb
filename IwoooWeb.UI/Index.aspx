<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IwoooWeb.UI.Index" %>

<%@ Register src="WebControl/Header.ascx" tagname="Header" tagprefix="ucHeader" %>
<%@ Register src="WebControl/NavigationBar.ascx" tagname="NavigationBar" tagprefix="ucNavigationBar" %>
<%@ Register src="WebControl/Slider.ascx" tagname="Slider" tagprefix="ucSlider" %>
<%@ Register src="WebControl/Social.ascx" tagname="Social" tagprefix="ucSocial" %>
<%@ Register src="WebControl/Footer.ascx" tagname="Footer" tagprefix="ucFooter" %>


<!DOCTYPE html>

<html lang="en" class="csstransforms csstransforms3d csstransitions js cssanimations csstransitions">

<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta charset="utf-8"/>
  <title>爱沃计算机科技有限公司</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
  <meta name="description" content=""/>
  <meta name="keywords" content=""/>
  <meta name="author" content=""/>


  <!-- Stylesheets -->
  <link href="style/bootstrap.css" rel="stylesheet"/>
  <link rel="stylesheet" href="style/font-awesome.css"/>
  <link href="style/prettyPhoto.css" rel="stylesheet"/>
  <!-- Parallax slider -->
  <link rel="stylesheet" href="style/slider.css"/>
  <!-- Flexslider -->
  <link rel="stylesheet" href="style/flexslider.css"/>

  <link href="style/style.css" rel="stylesheet"/>

  <!-- Colors - Orange, Purple, Light Blue (lblue), Red, Green and Blue -->
  <link href="style/green.css" rel="stylesheet"/>

  <link href="style/bootstrap-responsive.css" rel="stylesheet"/>
  
  <!-- HTML5 Support for IE -->
  <!--[if lt IE 9]>
  <script src="js/html5shim.js"></script>
  <![endif]-->

  <!-- Favicon -->
  <link rel="shortcut icon" href="img/favicon/favicon.png"/>
</head>

<body>
    <form id="form1" runat="server">
        <ucHeader:Header ID="Header" runat="server" />
        <ucNavigationBar:NavigationBar ID="NavigationBar" runat="server" />
        <div class="contain">
            <div class="container">
                <ucSlider:Slider ID="Slider" runat="server" />



            </div>
        </div>
        <ucSocial:Social ID="Social" runat="server" />
        <ucFooter:Footer ID="Footer" runat="server" />

    </form>
    <!-- JS -->
    <script src="js/jquery.js"></script>
    <script src="js/bootstrap.js"></script> 
    <script src="js/jquery.isotope.js"></script> <!-- Isotope for gallery -->
    <script src="js/jquery.prettyPhoto.js"></script> <!-- prettyPhoto for images -->
    <script src="js/jquery.cslider.js"></script> <!-- Parallax slider -->
    <script src="js/modernizr.custom.28468.js"></script>
    <script src="js/filter.js"></script> <!-- Filter for support page -->
    <script src="js/cycle.js"></script> <!-- Cycle slider -->
    <script src="js/jquery.flexslider-min.js"></script> <!-- Flex slider -->

    <script src="js/easing.js"></script> <!-- Easing -->
    <script src="js/custom.js"></script>

</body>
</html>
