<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="IwoooWeb.UI.ContactUs" %>

<%@ Register src="WebControl/Header.ascx" tagname="Header" tagprefix="ucHeader" %>
<%@ Register src="WebControl/NavigationBar.ascx" tagname="NavigationBar" tagprefix="ucNavigationBar" %>


<%@ Register src="WebControl/Social.ascx" tagname="Social" tagprefix="ucSocial" %>
<%@ Register src="WebControl/Footer.ascx" tagname="Footer" tagprefix="ucFooter" %>

<!DOCTYPE html>

<html lang="en" class="csstransforms csstransforms3d csstransitions js cssanimations csstransitions">

<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta charset="utf-8"/>
  <title>联系我们</title>
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
            <h2>Contact Us</h2>
            <p class="big grey">欢迎亲临本公司作客</p>
            <hr>
            
            <div class="contact">
                        <div class="row">
                            <div class="span12">
                                <!-- BaiDu maps -->
                                <div class="gmap">
                                    <!-- BaiDu Maps. Replace the below iframe with your BaiDu Maps embed code -->
                                    <iframe height="300" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="BaiDuMap.html"></iframe>
                                </div>
                              
                            </div>
                        </div>
                        <div class="row">
                            <div class="span6">
                                <div class="cwell">
                                    <!-- Contact form -->
                                    <h5>在线留言</h5>
                                    <div class="form">
                                        <!-- Contact form (not working)-->
                                        <div class="form-horizontal">
                                            <!-- Name -->
                                            <div class="control-group">
                                            <label class="control-label" for="name">姓名</label>
                                            <div class="controls">
                                                <input type="text" class="input-medium" id="txtName" name="txtName" runat="server">
                                            </div>
                                            </div>
                                            <!-- Email -->
                                            <div class="control-group">
                                            <label class="control-label" for="email">邮箱</label>
                                            <div class="controls">
                                                <input type="text" class="input-medium" id="txtEmail" name="txtEmail" runat="server">
                                            </div>
                                            </div>
                                            <!-- Website -->
                                            <div class="control-group">
                                            <label class="control-label" for="telphone">联系电话</label>
                                            <div class="controls">
                                                <input type="text" class="input-medium" id="txtTelphone" name="txtTelphone" runat="server">
                                            </div>
                                            </div>
                                            <!-- Comment -->
                                            <div class="control-group">
                                            <label class="control-label" for="comment">内容</label>
                                            <div class="controls">
                                                <textarea class="input-madium" id="txtComment" rows="3" name="txtComment" runat="server"></textarea>
                                            </div>
                                            </div>
                                            <!-- Buttons -->
                                            <div class="form-actions">
                                                <!-- Buttons -->
                                            <button id="sendMessage" type="submit" class="btn" onclick="SendMessage()">发送留言</button>
                                            <button type="reset" class="btn" onclick="CleanLeaveMessage()">重置</button>
                                            </div>
                                        </div>
                                    </div>
                               </div>
                            </div>
                            <div class="span6">
                                    <div class="cwell">
                                    <!-- Address section -->
                                        <h5>联系地址</h5>
                                        <div class="address">
                                            <address>
                                                <!-- Company name -->
                                                <h6><b>广州爱沃计算机科技有限公司</b></h6>
                                                <!-- Address -->
                                                中国 广州市天河路490号<br>
                                                壬丰大厦2311A室<br>
                                                <abbr title="PostCode">邮政编号：</abbr>510630<br />
                                                <!-- Phone number -->
                                                <abbr title="Phone">联系电话：</abbr> +(86)(020) 38732479 38732489 38732499 38731850.<br />
                                                <!-- Email -->
                                                <abbr title="Email">联系邮箱：</abbr>
                                                <a href="mailto:sales@iwooo.com">sales@iwooo.com</a>
                                                <a href="mailto:info@iwooo.com">info@iwooo.com</a>
                                                <a href="mailto:support@iwooo.com">support@iwooo.com</a>
                                            </address>                                    
                                        </div>
                                    </div>
                            </div>
                        </div>
                        
                        </div> 


            </div>
            </div>
        <ucSocial:Social ID="Social" runat="server" />
        <ucFooter:Footer ID="Footer" runat="server" />
    </form>

    <!-- JS -->
    <script src="js/jquery.js"></script>
<%--    <script src="js/bootstrap.js"></script> 
    <script src="js/jquery.isotope.js"></script> <!-- Isotope for gallery -->
    <script src="js/jquery.prettyPhoto.js"></script> <!-- prettyPhoto for images -->
    <script src="js/jquery.cslider.js"></script> <!-- Parallax slider -->
    <script src="js/modernizr.custom.28468.js"></script>
    <script src="js/filter.js"></script> <!-- Filter for support page -->
    <script src="js/cycle.js"></script> <!-- Cycle slider -->
    <script src="js/jquery.flexslider-min.js"></script> <!-- Flex slider -->

    <script src="js/easing.js"></script> <!-- Easing -->
    <script src="js/custom.js"></script>--%>
    <script>
        function CleanLeaveMessage() {
            $("#txtName").val("");
            $("#txtEmail").val("");
            $("#txtTelphone").val("");
            $("#txtComment").val("");
        };
        function SendMessage() {
            var xmlhttp;
            var name = $.trim($("#txtName").val());
            var email = $.trim($("#txtEmail").val());
            var telphone = $.trim($("#txtTelphone").val());
            var comment = $.trim($("#txtComment").val());
            if (name == "" || email == "" || telphone == "" || comment == "") {
                alert("需填写所有信息");
                return;
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
                    if (text == "1") {
                        $("#sendMessage").text("发送成功");
                    } else {
                        $("#sendMessage").text("发送失败");
                        $("#sendMessage").removeAttr("disabled");
                    }
                } else {
                    $("#sendMessage").attr("disabled", true);
                    $("#sendMessage").text("发送中..");
                };
            };
            xmlhttp.open("GET", "/ajaxAspx/sendEmail.aspx?txtName=" + name + "&txtEmail=" + email + "&txtTelphone=" + telphone + "&txtComment=" + comment, true);
            xmlhttp.send();
        };
    </script>
</body>
</html>
