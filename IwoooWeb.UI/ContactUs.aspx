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
                                      <form class="form-horizontal">
                                          <!-- Name -->
                                          <div class="control-group">
                                            <label class="control-label" for="name">姓名</label>
                                            <div class="controls">
                                              <input type="text" class="input-medium" id="name">
                                            </div>
                                          </div>
                                          <!-- Email -->
                                          <div class="control-group">
                                            <label class="control-label" for="email">邮箱</label>
                                            <div class="controls">
                                              <input type="text" class="input-medium" id="email">
                                            </div>
                                          </div>
                                          <!-- Website -->
                                          <div class="control-group">
                                            <label class="control-label" for="telphone">联系电话</label>
                                            <div class="controls">
                                              <input type="text" class="input-medium" id="telphone">
                                            </div>
                                          </div>
                                          <!-- Comment -->
                                          <div class="control-group">
                                            <label class="control-label" for="comment">内容</label>
                                            <div class="controls">
                                              <textarea class="input-madium" id="comment" rows="3"></textarea>
                                            </div>
                                          </div>
                                          <!-- Buttons -->
                                          <div class="form-actions">
                                             <!-- Buttons -->
                                            <button type="submit" class="btn">发送留言</button>
                                            <button type="reset" class="btn">重置</button>
                                          </div>
                                      </form>
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
                                              <h6>Responsive Web, Inc.</h6>
                                              <!-- Address -->
                                              795 Folsom Ave, Suite 600<br>
                                              San Francisco, CA 94107<br>
                                              <!-- Phone number -->
                                              <abbr title="Phone">P:</abbr> (123) 456-7890.
                                           </address>
                                            
                                           <address>
                                              <!-- Name -->
                                              <h6>Full Name</h6>
                                              <!-- Email -->
                                              <a href="mailto:#">first.last@gmail.com</a>
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
