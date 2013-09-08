<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ajaxShow.aspx.cs" Inherits="IwoooWeb.UI.ajaxAspx.CompanyIntroduction" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div runat="server" id="strContent">
        <!--CompanyNewsTable-->
<div class="row">

<div class="span12">
    <asp:GridView ID="tbCompanyNews" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-hover table-bordered" OnRowDataBound="tbCompanyNews_RowDataBound">
            <Columns>
                <asp:BoundField DataField="row" HeaderStyle-Width="50px"> </asp:BoundField>
                <asp:BoundField DataField="newTittle"> </asp:BoundField>
                <asp:BoundField DataField="newDate" HeaderStyle-Width="150px"> </asp:BoundField>
            </Columns>
    </asp:GridView>
    <%--<asp:Table ID="tbCompanyNews" runat="server" CssClass="table table-striped table-hover table-bordered"></asp:Table>--%>
<%--<table class="table table-striped table-hover table-bordered">
    <thead>
    <tr>
        <th>#</th>
        <th>Name</th>
        <th>Earnings</th>
        <th>Order ID</th>
        <th>Buyer</th>
        <th>Date</th>
    </tr>
    </thead>
    <tbody>
    <tr>
        <td>1</td>
        <td>Sony Xperia Pro X1242</td>
        <td>$25</td>
        <td>534343</td>
        <td>Ravi Kumar</td>
        <td>3 Days ago</td>
    </tr>     
    <tr>
        <td>2</td>
        <td>Apple iPhone 6G - Black</td>
        <td>$15</td>
        <td>565445</td>
        <td>Babu Raj</td>
        <td>6 Days ago</td>
    </tr>                                                                        <tr>
        <td>3</td>
        <td>Samsung Galaxy Metro</td>
        <td>$35</td>
        <td>976876</td>
        <td>Ashok</td>
        <td>8 Days ago</td>
    </tr> 
    <tr>
        <td>4</td>
        <td>Nokia Lumina Asha</td>
        <td>$22</td>
        <td>232454</td>
        <td>Raja Ram</td>
        <td>10 Days ago</td>
    </tr> 
    <tr>
        <td>5</td>
        <td>Motorola Razr 5304</td>
        <td>$18</td>
        <td>787876</td>
        <td>Kumerasa</td>
        <td>12 Days ago</td>
    </tr> 
    <tr>
        <td>6</td>
        <td>Micromox Canvas Small</td>
        <td>$30</td>
        <td>656543</td>
        <td>Sagunai</td>
        <td>15 Days ago</td>
    </tr>                                                                                                                     
    <tr>  
        <td></td>
        <td><strong>Total</strong></td>
        <td><strong>$485</strong></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    </tbody>
</table>--%>
<%--    <div runat="server" id="divCountLine">
        <!--CountLine-->
        <div class="paging">
            <span class="current">1</span>
            <a href="#">2</a>
            <span class="dots">…</span>
            <a href="#">6</a>
            <a href="#">Next</a>
        </div> 
        <!--CountLineEnd-->
    </div>--%>
</div>
</div>
        <!--CompanyNewsTableEnd-->
    </div>
    </form>
</body>
</html>
