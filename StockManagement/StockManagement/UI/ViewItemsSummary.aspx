<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewItemsSummary.aspx.cs" Inherits="StockManagement.UI.ViewItemsSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Button ID="btnWelcome" runat="server" Text="Welcome" Width="140px" OnClick="btnWelcome_Click" style="height: 26px" />
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
        <asp:Label ID="Label1" runat="server" Text="View Items Summary"></asp:Label>
         <br />
        <br />
        Company&nbsp;
        <asp:DropDownList ID="ddCompanyId" runat="server" DataTextField="CompanyName" DataValueField="CompanyId" OnSelectedIndexChanged="ddCompanyId_SelectedIndexChanged" Width="131px">
        </asp:DropDownList>
         <br />
        <br />
        Category&nbsp;&nbsp; <asp:DropDownList ID="ddCategoryId" runat="server" DataTextField="CategoryName" DataValueField="CategoryId" Width="127px">
        </asp:DropDownList>
         <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
         <br />
         <br />
        <asp:GridView ID="gridViewItemSummary" runat="server">
        </asp:GridView>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
