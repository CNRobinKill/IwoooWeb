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
                    <h5><b>欢迎来到爱沃</b></h5>
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
        <span style="display:none" id="hideIndex">1</span>
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
            var htmlNow = document.getElementById("divAjaxShow").innerHTML;
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
                        $("#divAjaxShow").html(text).fadeIn("fast");
                    };
                } else {
                    $("#divAjaxShow").fadeOut("fast");
                };
            };
            xmlhttp.open("GET", '/ajaxAspx/ajaxShow.aspx?q=' + str1, true);
            xmlhttp.send();
        };

        function listLiComment(str1, str3) {
            var xmlhttp;
            var htmlNow = document.getElementById("divLiComment").innerHTML;
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
                        $("#divLiComment").html(text).hide().slideDown();
                    } else {
                        $("#divLiComment").html(text).fadeIn("fast");
                    };
                } else {
                    $("#divLiComment").fadeOut("fast");
                };
            };
            xmlhttp.open("GET", '/ajaxAspx/ajaxShow.aspx?r=' + str1 + '&l=' + str3, true);
            xmlhttp.send();
        };

        function showNewContent(str1) {
            var xmlhttp;

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
                    $("#divAjaxShow").html(text).fadeIn("fast");
                } else {
                    $("#divAjaxShow").fadeOut("fast");
                };
            };
            xmlhttp.open("GET", '/ajaxAspx/ajaxShow.aspx?n=' + str1, true);
            xmlhttp.send();
        };

        function selectIndex(str1,str2) {
            var xmlhttp;
            if (str2 == 0) {
                if ($("#hideIndex").text() == str1 || parseInt($("div.paging span").eq(-2).text()) < str1) {
                    return;
                };
            }
            if (window.XMLHttpRequest) {
                xmlhttp = new XMLHttpRequest();
            } else {
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            };
            xmlhttp.onreadystatechange = function () {
                if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                    $("#hideIndex").text(str1);
                    var text = xmlhttp.responseText;
                    var l = text.indexOf("\r");
                    text = text.substr(0, l);
                    if (str2 == 1) {
                        $("#divAjaxShow").html(text).fadeIn("fast");
                    } else {
                        $("#companyNewsTable").html(text).fadeIn("fast");
                    };
                    changeIndex(str2);
                    $("div.paging >span.current").removeClass();
                    $("div.paging >span").map(function () { if ($(this).text() == $("#hideIndex").text()) return this; }).addClass("current");                 
                } else {
                    if (str2 == 1) {
                        $("#divAjaxShow").fadeOut("fast");
                    } else {
                        $("#companyNewsTable").fadeOut("fast");
                    };                  
                };
            };
            xmlhttp.open("GET", '/ajaxAspx/ajaxShow.aspx?i=' + str1 + '&j=' + str2 + '&s=' + $("#hideIndex").text(), true);
            xmlhttp.send();
        };


        function changeIndex(str1) {
            if (str1 == 0) {
                if (parseInt($("#hideIndex").text()) <= parseInt($("div.paging span").eq(4).text())) {
                    return;
                };
                if (parseInt($("#hideIndex").text()) < parseInt($("div.paging span").eq(-2).text()) - 3) {
                    if (parseInt($("div.paging span").eq(4).text()) < parseInt($("div.paging span").eq(-2).text()) - 8) {
                        for (var i = 0; i < 5; i++) {
                            $("div.paging span").eq(i).text(parseInt($("div.paging span").eq(4).text()) + i - 1);
                        };
                    } else {
                        for (var i = 0; i < 10; i++) {
                            $("div.paging span").eq(i).text(parseInt($("div.paging span").eq(9).text()) + i - 9);
                        };
                        $("div.paging span").eq(5).attr('onclick', 'selectIndex($(this).text(),0)');
                    };
                    $("div.paging >span.current").removeClass();
                    $("div.paging >span").map(function () { if ($(this).text() == $("#hideIndex").text()) return this; }).addClass("current");
                };
            };
            if (str1 == 1) {
                if (parseInt($("div.paging span").eq(4).text()) < parseInt($("#hideIndex").text()) || parseInt($("#hideIndex").text()) < parseInt($("div.paging span").eq(0).text())) {
                    if (parseInt($("div.paging span").eq(-2).text()) - 8 < parseInt($("#hideIndex").text())) {
                        for (var i = 0; i < 10; i++) {
                            $("div.paging span").eq(i).text(parseInt($("div.paging span").eq(9).text()) + i - 9);
                        };
                        $("div.paging span").eq(5).attr('onclick', 'selectIndex($(this).text(),0)');
                    } else {
                        for (var i = 0; i < 5; i++) {
                            $("div.paging span").eq(i).text(parseInt($("#hideIndex").text()) + i - 1);
                        };
                    };
                };
            };
            if (str1 == 2) {
                if (parseInt($("div.paging span").eq(4).text()) < parseInt($("div.paging span").eq(-2).text()) - 8) {
                    for (var i = 0; i < 5; i++) {
                        $("div.paging span").eq(i).text(parseInt($("div.paging span").eq(4).text()) + i - 1);
                    };
                } else {
                    for (var i = 0; i < 10; i++) {
                        $("div.paging span").eq(i).text(parseInt($("div.paging span").eq(9).text()) + i - 9);
                    };
                    $("div.paging span").eq(5).attr('onclick', 'selectIndex($(this).text(),0)');
                };
                $("div.paging >span.current").removeClass();
                $("div.paging >span").map(function () { if ($(this).text() == $("#hideIndex").text()) return this; }).addClass("current");
            };
        };
                
     </script>
</body>
</html>
