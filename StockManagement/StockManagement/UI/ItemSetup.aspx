<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemSetup.aspx.cs" Inherits="StockManagement.UI.ItemSetup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Button ID="btnWelcome" runat="server" Text="Welcome" Width="140px" OnClick="btnWelcome_Click1" />
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
        <asp:Label ID="Label1" runat="server" Text="Item Setup"></asp:Label>
        <br />
        <br />
        <br />
        <div>
        </div>
        Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="ddCategoryId" runat="server" DataTextField="CategoryName" DataValueField="CategoryId" Height="16px" Width="128px">
        </asp:DropDownList>
         <br />
        <br />
        Company&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="ddCompanyId" runat="server" DataTextField="CompanyName" DataValueField="CompanyId" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="16px" Width="129px">
        </asp:DropDownList>
         <br />
        <br />
        Item Name&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
         <br />
        <br />
        Reorder Level&nbsp; <asp:TextBox ID="txtReorderLevel" runat="server">0</asp:TextBox>
         <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" />
        &nbsp;<br />
        <asp:Label ID="lblShow" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    </form>
</body>
</html>
