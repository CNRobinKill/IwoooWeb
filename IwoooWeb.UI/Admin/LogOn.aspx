<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="IwoooWeb.UI.Admin.LogOn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台登录</title>
    <!-- Stylesheets -->
  <link href="../style/bootstrap.css" rel="stylesheet"/>
  <link rel="stylesheet" href="../style/font-awesome.css"/>
  <link href="../style/prettyPhoto.css" rel="stylesheet"/>
  <!-- Parallax slider -->
  <link rel="stylesheet" href="../style/slider.css"/>
  <!-- Flexslider -->
  <link rel="stylesheet" href="../style/flexslider.css"/>

  <link href="../style/style.css" rel="stylesheet"/>

  <!-- Colors - Orange, Purple, Light Blue (lblue), Red, Green and Blue -->
  <link href="../style/green.css" rel="stylesheet"/>

  <link href="../style/bootstrap-responsive.css" rel="stylesheet"/>
  
  <!-- HTML5 Support for IE -->
  <!--[if lt IE 9]>
  <script src="js/html5shim.js"></script>
  <![endif]-->

  <!-- Favicon -->
  <link rel="shortcut icon" href="../img/favicon/favicon.png"/>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:100%;height:600px;line-height:600px;text-align:center" >
        <div style="text-align:center;">
        用户名：<asp:TextBox ID="txtUserName" runat="server" CssClass="input-medium" Width="200"></asp:TextBox>
        密&nbsp;&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="txtPassword" runat="server" CssClass="input-medium"  Width="200" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogOn" runat="server" Text="登录" CssClass="btn" />
        </div>
    </div>
    </form>
</body>
</html>
