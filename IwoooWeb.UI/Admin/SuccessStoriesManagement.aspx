<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SuccessStoriesManagement.aspx.cs" Inherits="IwoooWeb.UI.Admin.SuccessStoriesManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
    <asp:Button ID="btnAddSuccessStories" runat="server" Text="添加成功案例" CssClass="btn" OnClick="btnAddSuccessStories_Click"/>
    </div>
    <hr />
    <div>
        <asp:GridView ID="tbSuccessStories" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" OnRowDeleting="tbSuccessStories_RowDeleting" OnSelectedIndexChanging="tbSuccessStories_SelectedIndexChanging" >
            <Columns>
                <asp:BoundField DataField="successStoriesName"> </asp:BoundField>
                <asp:BoundField DataField="successStoriesYear" HeaderStyle-Width="150px"> </asp:BoundField>
                <asp:CommandField ShowSelectButton="true" SelectText="修改" HeaderStyle-Width="50px" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
    </div>
</asp:Content>
