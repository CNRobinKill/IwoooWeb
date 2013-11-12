<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="NewsManagement.aspx.cs" Inherits="IwoooWeb.UI.Admin.NewsManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
    <asp:Button ID="btnAddNews" runat="server" Text="添加新闻" CssClass="btn" OnClick="btnAddNews_Click" />
    </div>
    <hr />
    <div>
        <asp:GridView ID="tbCompanyNews" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" OnSelectedIndexChanging="tbCompanyNews_SelectedIndexChanging" OnRowDeleting="tbCompanyNews_RowDeleting" >
            <Columns>
                <asp:BoundField DataField="row" HeaderStyle-Width="50px"> </asp:BoundField>
                <asp:BoundField DataField="newTittle"> </asp:BoundField>
                <asp:BoundField DataField="newDate" HeaderStyle-Width="150px"> </asp:BoundField>
                <asp:CommandField ShowSelectButton="true" SelectText="修改" HeaderStyle-Width="50px" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
    </div>
</asp:Content>
