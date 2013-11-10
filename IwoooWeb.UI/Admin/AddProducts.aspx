<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="IwoooWeb.UI.Admin.AddProducts" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/ueditor/themes/default/css/ueditor.css" rel="stylesheet" />

    <script type="text/javascript">
        window.UEDITOR_HOME_URL = "/ueditor/";
    </script>   
    <script src="/ueditor/ueditor.config.js"></script>
    <script src="/ueditor/ueditor.all.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
    <asp:Button ID="btnAddProducts" runat="server" Text="确认添加" CssClass="btn" Visible="false" OnClick="btnAddProducts_Click" /><asp:Button ID="btnUpdProducts" runat="server" Text="确认修改" CssClass="btn" Visible="false" OnClick="btnUpdProducts_Click" />
    </div>
    <hr />
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1"><asp:Label runat="server" Text="产品大类："></asp:Label></td>
            <td>
                <asp:DropDownList ID="ddlType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlType_SelectedIndexChanged">
                    <asp:ListItem  Value="0">硬件产品</asp:ListItem>
                    <asp:ListItem  Value="1">软件产品</asp:ListItem>
                    <asp:ListItem  Value="2">服务产品</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Label  runat="server" Text="产品类别："></asp:Label></td>
            <td><asp:DropDownList ID="ddlProductType" runat="server"  OnDataBound="ddlProductType_DataBound"></asp:DropDownList>新建类别：<asp:TextBox ID="txtProductType" runat="server" CssClass="input-medium" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Label runat="server" Text="产品名称："></asp:Label></td>
            <td><asp:TextBox ID="txtProductName" runat="server" CssClass="input-medium" Width="200px"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style1"><asp:Label  runat="server" Text="展示图片："></asp:Label><br /></td>
            <td><asp:FileUpload ID="fuPic"   runat="server" /></td>
        </tr>
    </table>
    <asp:Label ID="Label2" runat="server" Text="产品详情："></asp:Label>
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
