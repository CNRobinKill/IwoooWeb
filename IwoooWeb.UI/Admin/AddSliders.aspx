<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddSliders.aspx.cs" Inherits="IwoooWeb.UI.Admin.AddSliders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
    <asp:Button ID="btnAddNews" runat="server" Text="确认添加" CssClass="btn" OnClick="btnAddNews_Click"  />
    </div>
    <hr />
    <table style="width: 100%;">
        <tr>
            <td><asp:Label  runat="server" Text="主题："></asp:Label></td>
            <td><asp:TextBox ID="txtSliderName" runat="server" CssClass="input-medium" Width="250px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="主题简介："></asp:Label></td>
            <td><asp:TextBox ID="txtSliderContent" runat="server" CssClass="input-medium" Width="500px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="链接地址："></asp:Label></td>
            <td><asp:TextBox ID="txtSliderLink" runat="server" CssClass="input-medium" Width="250px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label  runat="server" Text="展示图片："></asp:Label><br /></td>
            <td><asp:FileUpload ID="fuPic"   runat="server" /></td>
        </tr>
    </table>
</asp:Content>
