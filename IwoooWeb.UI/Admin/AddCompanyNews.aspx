<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddCompanyNews.aspx.cs" Inherits="IwoooWeb.UI.Admin.AddCompanyNews" ValidateRequest="false"%>
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
    <asp:Button ID="btnAddNews" runat="server" Text="确认添加" CssClass="btn" Visible="false" OnClick="btnAddNews_Click" /><asp:Button ID="btnUpdNews" runat="server" Text="确认修改" CssClass="btn" Visible="false" OnClick="btnUpdNews_Click" />
    </div>
    <hr />
    <asp:Label  runat="server" Text="新闻标题："></asp:Label>
    <asp:TextBox ID="txtTittle" runat="server" CssClass="input-medium" Width="500px"></asp:TextBox><br />
    <asp:Label  runat="server" Text="新闻内容："></asp:Label>
    <script type="text/plain" id="editor" name="myContent"></script>
    <script type="text/javascript">
        var options = {
            initialFrameWidth: 800,
            initialFrameHeight: 420,
            focus: true
        };
        var editor = new UE.ui.Editor(options);
        editor.render("editor");
    </script>

</asp:Content>
