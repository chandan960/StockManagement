<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSalesSummary.aspx.cs" Inherits="StockManagement.UI.ViewSalesSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnWelcome" runat="server" Text="Welcome" Width="140px" OnClick="btnWelcome_Click" />
            <asp:Button ID="btnCategory" runat="server" Text="Category" Width="140px" OnClick="btnCategory_Click" />
            <asp:Button ID="btnComnpany" runat="server" Text="Comnpany" Width="140px" OnClick="btnComnpany_Click" />
            <asp:Button ID="btnItem" runat="server" Text="Item" Width="140px" OnClick="btnItem_Click" />
            <asp:Button ID="btnStockIn" runat="server" Text="Stock In" Width="140px" OnClick="btnStockIn_Click" />
            <asp:Button ID="btnStockOut" runat="server" Text="StockOut" Width="140px" OnClick="btnStockOut_Click" />
            <asp:Button ID="btnItemSummary" runat="server" Text="Item Summary" Width="140px" OnClick="btnItemSummary_Click" />
            <asp:Button ID="btnSalesSummary" runat="server" Text="Sales Summary" Width="140px" OnClick="btnSalesSummary_Click" />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="View Sales Summary"></asp:Label>
        <br />
        <br />
        <br />
        From Date&nbsp; <asp:TextBox ID="txtFromDate" runat="server" Type="date"></asp:TextBox>
        &nbsp;<br />
        <br />
        To Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtToDate" runat="server" Type="date"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="gridViewSalesSummary" runat="server">
        </asp:GridView>
        <br />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
