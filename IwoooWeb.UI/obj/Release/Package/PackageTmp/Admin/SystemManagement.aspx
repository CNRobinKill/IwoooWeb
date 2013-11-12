<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SystemManagement.aspx.cs" Inherits="IwoooWeb.UI.Admin.SystemManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
     <div style="text-align:right">
    <asp:Button ID="btnUpa" runat="server" Text="确认修改" CssClass="btn" OnClick="btnUpa_Click"  />
    </div>
    <hr />
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1"><asp:Label  runat="server" Text="管理账号："></asp:Label></td>
            <td><asp:Label ID="lblSystemID"  runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Label runat="server" Text="原密码："></asp:Label></td>
            <td><asp:TextBox ID="txtPassword" runat="server" CssClass="input-medium" Width="200px" TextMode="Password" ></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Label runat="server" Text="新密码："></asp:Label></td>
            <td><asp:TextBox ID="txtNewPassword" runat="server" CssClass="input-medium" Width="200px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Label runat="server" Text="校验密码："></asp:Label><br /></td>
            <td><asp:TextBox ID="txtRePassword" runat="server" CssClass="input-medium" Width="200px" TextMode="Password"></asp:TextBox></td>
        </tr>
    </table>
</asp:Content>
