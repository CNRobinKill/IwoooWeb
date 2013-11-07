<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="HomePageSetting.aspx.cs" Inherits="IwoooWeb.UI.Admin.HomePageSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">

<div style="text-align:right">
    <asp:Button ID="btnAddSlider" runat="server" Text="添加首页轮番" CssClass="btn" OnClick="btnAddSlider_Click"/>
    </div>
    <hr />
    <div>
        <asp:GridView ID="tbSlider" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" OnRowDeleting="tbSlider_RowDeleting" >
            <Columns>
                <asp:BoundField DataField="sliderName" HeaderStyle-Width="150px"> </asp:BoundField>
                <asp:BoundField DataField="sliderLink"> </asp:BoundField>
                <asp:BoundField DataField="sliderPhoto" HeaderStyle-Width="200px"> </asp:BoundField>
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
    </div>
</asp:Content>
