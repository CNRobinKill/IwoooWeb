<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="IwoooWeb.UI.WebControl.Header" %>
<!-- Header Starts -->
<header>
  <div class="container">
    <div class="row">
      <div class="span6">
        <div class="logo">
          <h1><a href="#">I<span class="color">wooo</span></a></h1>
          <div class="hmeta">Welcome To Iwooo</div>
        </div>
      </div>
      <div class="span6">
        <div class="form">
          <form method="get" id="searchform" action="#" class="form-search">
            <input type="text" value="" name="s" id="s" class="input-medium">
              <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn" />
            <%--<button type="submit" class="btn">Search</button>--%>
          </form>
        </div>
      </div>
    </div>
  </div>
</header>