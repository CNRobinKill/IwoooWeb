<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="IwoooWeb.UI.Admin.ProductManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
        <asp:Button ID="btnAddProducts" runat="server" Text="添加产品" CssClass="btn" OnClick="btnAddProducts_Click" />
    </div>
    <hr />
    <div style="text-align:center">
        <asp:Label runat="server" Text="点击查看："></asp:Label>
        <asp:Button ID="btnShowHardWare" runat="server" Text="硬件产品" CssClass="btn" OnClick="btnShowHardWare_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShowSoftWare" runat="server" Text="软件产品" CssClass="btn" OnClick="btnShowSoftWare_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShowServices" runat="server" Text="服务产品" CssClass="btn" OnClick="btnShowServices_Click" />
    </div>
    <hr />
    <div>
        <asp:GridView ID="tbHardWare" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" Visible="false" OnRowDeleting="tbHardWare_RowDeleting" OnSelectedIndexChanging="tbHardWare_SelectedIndexChanging" >
            <Columns>
                <asp:BoundField DataField="hardWareType" HeaderStyle-Width="150px"> </asp:BoundField>
                <asp:BoundField DataField="hardWareName"> </asp:BoundField>
                <asp:CommandField ShowSelectButton="true" SelectText="修改" HeaderStyle-Width="50px" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
        <asp:GridView ID="tbSoftWare" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" Visible="false" OnRowDeleting="tbSoftWare_RowDeleting" OnSelectedIndexChanging="tbSoftWare_SelectedIndexChanging" >
            <Columns>
                <asp:BoundField DataField="softWareType" HeaderStyle-Width="150px"> </asp:BoundField>
                <asp:BoundField DataField="softWareName"> </asp:BoundField>
                <asp:CommandField ShowSelectButton="true" SelectText="修改" HeaderStyle-Width="50px" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
        <asp:GridView ID="tbServices" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" Visible="false" OnRowDeleting="tbServices_RowDeleting" OnSelectedIndexChanging="tbServices_SelectedIndexChanging" >
            <Columns>
                <asp:BoundField DataField="servicesType" HeaderStyle-Width="150px"> </asp:BoundField>
                <asp:BoundField DataField="servicesName"> </asp:BoundField>
                <asp:CommandField ShowSelectButton="true" SelectText="修改" HeaderStyle-Width="50px" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
    </div>
</asp:Content>
