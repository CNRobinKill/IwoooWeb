<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajaxShow.aspx.cs" Inherits="IwoooWeb.UI.ajaxAspx.CompanyIntroduction" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="tbCompanyNews" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" OnRowDataBound="tbCompanyNews_RowDataBound">
            <Columns>
                <asp:BoundField DataField="row" HeaderStyle-Width="50px"> </asp:BoundField>
                <asp:BoundField DataField="newTittle"> </asp:BoundField>
                <asp:BoundField DataField="newDate" HeaderStyle-Width="150px"> </asp:BoundField>
            </Columns>
    </asp:GridView>
</div>
    </form>
</body>
</html>
