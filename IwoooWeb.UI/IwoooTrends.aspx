<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IwoooTrends.aspx.cs" Inherits="IwoooWeb.UI.IwoooTrends" %>

<%@ Register src="WebControl/Header.ascx" tagname="Header" tagprefix="ucHeader" %>
<%@ Register src="WebControl/NavigationBar.ascx" tagname="NavigationBar" tagprefix="ucNavigationBar" %>


<%@ Register src="WebControl/Social.ascx" tagname="Social" tagprefix="ucSocial" %>
<%@ Register src="WebControl/Footer.ascx" tagname="Footer" tagprefix="ucFooter" %>

<!DOCTYPE html>

<html lang="en" class="csstransforms csstransforms3d csstransitions js cssanimations csstransitions">

<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta charset="utf-8"/>
  <title>爱沃动态</title>
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

  <hr>
                <div class="row">
                    <div class="span12">
                    <h2>欢迎来到爱沃</h2>
                    <p>爱沃计算机科技有限公司，是中国区专业IT信息系统提供商，致力于为众多用户及合作伙伴提供完善的IT服务、IT产品及IT信息方案。</p>
                    <hr>
                    </div>                 
                </div>

              <div class="features-four">

              <div class="row">
                <div class="span4">                  
                          <div class="f-block b-green" onclick="divAjaxShow('CompanyIntroduction')" style="cursor:pointer">
                                <i class="icon-briefcase"></i>                 
                                <h4>介绍爱沃</h4>
                                <p>我们是否有些信息吸引到您？合作只因我们双方了解，现在由您对我们团队进行了解开始。</p>
                          </div>
                </div>

                <div class="span4">
                          <div class="f-block b-purple" onclick="divAjaxShow('CompanyNews')" style="cursor:pointer">
                                <i class="icon-briefcase"></i>
                                <h4>爱沃新闻</h4>
                                <p>这里可以让您了解到我们团队经历的一些有趣故事以及最新动态。</p>
                          </div>
                </div>

                <div class="span4">
                          <div class="f-block b-lblue" onclick="divAjaxShow('JoinUs')" style="cursor:pointer">
                                <i class="icon-briefcase"></i>
                                <h4>加入我们</h4>
                                <p>如果你对我们团队感兴趣，如果你是我们在寻找的人，那么赶紧加入我们吧。</p>
                          </div>
                </div>        

              </div>
            </div>
                
    <hr>
                    <div id="divAjaxShow"></div>


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

    <script type="text/javascript">
        function divAjaxShow(str1) {
            var xmlhttp;
            var htmlNow = document.getElementById('divAjaxShow').innerHTML;
            if (htmlNow != "") {
                var e = htmlNow.indexOf("-->") - 4;
                var str2 = htmlNow.substr(4, e);
                if (str1 == str2) {
                    return;
                };
            };

            if (window.XMLHttpRequest) {
                xmlhttp = new XMLHttpRequest();
            } else {
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            };
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    var text = xmlhttp.responseText;
                    var l = text.indexOf("\r");
                    text = text.substr(0, l);
                    if (htmlNow == "") {
                        $("#divAjaxShow").html(text).hide().slideDown();
                    } else {
                        $("#divAjaxShow").html(text).fadeOut("fast").fadeIn("fast");
                    };
                    //document.getElementById('divAjaxShowCompanyIntroduction').innerHTML = text;
                };
                //else {
                //    document.getElementById("divAjaxShow").innerHTML = "<div class='row'><div class='span12'>  <div class='well c-soon'><img alt='wait' src='/img/wait.gif'></img></div></div></div>";
                //}
            };
            xmlhttp.open("GET", '/ajaxAspx/ajaxShow.aspx?q=' + str1, true);
            xmlhttp.send();
        };
     </script>
</body>
</html>
