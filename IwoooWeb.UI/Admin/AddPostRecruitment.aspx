<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddPostRecruitment.aspx.cs" Inherits="IwoooWeb.UI.Admin.AddPostRecruitment"  ValidateRequest="false"%>
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
    <asp:Button ID="btnAddPosition" runat="server" Text="确认添加" CssClass="btn" Visible="false" OnClick="btnAddPosition_Click" /><asp:Button ID="btnUpdPosition" runat="server" Text="确认修改" CssClass="btn" Visible="false" OnClick="btnUpdPosition_Click" />
    </div>
    <hr />
    <asp:Label  runat="server" Text="发布职位："></asp:Label>
    <asp:TextBox ID="txtPosition" runat="server" CssClass="input-medium" Width="350px"></asp:TextBox><br />
    <asp:Label runat="server" Text="招聘详细："></asp:Label>
    <script type="text/plain" id="editor" name="myContent"></script>
    <script type="text/javascript">
        var options = {
            initialFrameWidth: 660,
            initialFrameHeight: 420,
            focus: true
        };
        var editor = new UE.ui.Editor(options);
        editor.render("editor");
    </script>
</asp:Content>
