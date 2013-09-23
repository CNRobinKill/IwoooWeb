<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddCompanyNews.aspx.cs" Inherits="IwoooWeb.UI.Admin.AddCompanyNews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <asp:Label  runat="server" Text="新闻标题："></asp:Label>
    <asp:TextBox ID="txtTittle" runat="server" CssClass="input-medium" Width="300px"></asp:TextBox><br />
    <asp:Label  runat="server" Text="新闻内容："></asp:Label>

</asp:Content>
