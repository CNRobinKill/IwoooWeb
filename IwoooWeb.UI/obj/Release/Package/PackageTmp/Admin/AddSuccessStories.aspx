<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddSuccessStories.aspx.cs" Inherits="IwoooWeb.UI.Admin.AddSuccessStories"  ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/ueditor/themes/default/css/ueditor.css" rel="stylesheet" />

    <script type="text/javascript">
        window.UEDITOR_HOME_URL = "/ueditor/";
    </script>   
    <script src="/ueditor/ueditor.config.js"></script>
    <script src="/ueditor/ueditor.all.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
    <asp:Button ID="btnAddSuccessStories" runat="server" Text="确认添加" CssClass="btn" Visible="false" OnClick="btnAddSuccessStories_Click" /><asp:Button ID="btnUpdSuccessStories" runat="server" Text="确认修改" CssClass="btn" Visible="false" OnClick="btnUpdSuccessStories_Click" />
    </div>
    <hr />
    <table style="width: 100%;">
        <tr>
            <td><asp:Label runat="server" Text="案例标题："></asp:Label></td>
            <td><asp:TextBox ID="txtSuccessStoriesName" runat="server" CssClass="input-medium" Width="350px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label runat="server" Text="案例期（年）："></asp:Label></td>
            <td><asp:TextBox ID="txtSuccessStoriesYear" runat="server" CssClass="input-medium" Width="150px"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="案例详细："></asp:Label></td>
            <td>&nbsp;</td>
        </tr>
    </table>
      
    <script type="text/plain" id="editor" name="myContent"></script>
    <script type="text/javascript">
        var options = {
            initialFrameWidth: 938,
            initialFrameHeight: 420,
            focus: true
        };
        var editor = new UE.ui.Editor(options);
        editor.render("editor");
    </script>
</asp:Content>
