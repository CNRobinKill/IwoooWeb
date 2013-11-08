<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="PostRecruitment.aspx.cs" Inherits="IwoooWeb.UI.Admin.PostRecruitment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" runat="server">
    <div style="text-align:right">
    <asp:Button ID="btnAddPosition" runat="server" Text="添加职位" CssClass="btn" OnClick="btnAddPosition_Click" />
    </div>
    <hr />
    <div>
        <asp:GridView ID="tbJoinUs" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" OnRowDeleting="tbJoinUs_RowDeleting" OnSelectedIndexChanging="tbJoinUs_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="position"> </asp:BoundField>
                <asp:CommandField ShowSelectButton="true" SelectText="修改" HeaderStyle-Width="50px" />
                <asp:CommandField ShowDeleteButton="true" DeleteText="删除" HeaderStyle-Width="50px" />
            </Columns>
    </asp:GridView>
    </div>
</asp:Content>
