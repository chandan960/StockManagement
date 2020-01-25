<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategorySetup.aspx.cs" Inherits="StockManagement.UI.CategorySetup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Button ID="btnWelcome" runat="server" Text="Home" Width="140px" OnClick="btnWelcome_Click" />
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
        <asp:Label ID="Label1" runat="server" Text="Category Setup"></asp:Label>
        <br />
        <br />
        <br />
        <div>
        </div>
        Name&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCategorySave" runat="server" OnClick="btnCategorySave_Click" Text="Save" />
        </p>
        <p>
            <asp:Label ID="lblShow" runat="server"></asp:Label>
        </p>
         <p>
             <asp:Label ID="Label2" runat="server" Text="View Category"></asp:Label>
        </p>
        <asp:GridView ID="gridCategorys" runat="server" OnSelectedIndexChanged="gridCategorys_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
