using StockManagement.BLL;
using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagement.UI
{
    public partial class StockIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDdCompany();
            }
        }
        private void BindDdCompany()
        {
            CompanyManager aManager = new CompanyManager();
            ddCompanyId.DataSource = aManager.GetAllCompany();
            ddCompanyId.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ddCompanyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(ddCompanyId.SelectedValue);
            BindDdItem(companyId);
        }

        private void BindDdItem(int companyId)
        {
            ItemManager aManager = new ItemManager();
            ddItemId.DataSource = aManager.GetItemList(companyId);
            ddItemId.DataBind();
        }

        protected void ddItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            BindDdReOrderLevel(itemId);
            BindDdAvailableQuantity(itemId);
        }

         private void BindDdReOrderLevel(int itemId)
        {
            ItemManager aManager = new ItemManager();
            txtReorderLevel.Text = aManager.GetReOrderLevel(itemId).ToString();
        }

        private void BindDdAvailableQuantity(int itemId)
        {
            StockManager aManager = new StockManager();
            int StockIn = aManager.GetStockIn(itemId);
            int Sell = aManager.GetSell(itemId);
            int Damage = aManager.GetDamage(itemId);
            int Lost = aManager.GetLost(itemId);
            int StockOut = Sell + Damage + Lost;
            int AvailableQuantity = StockIn - StockOut;
            txtAvailableQuantity.Text = AvailableQuantity.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            int stockInQuantity = Convert.ToInt32(txtStockInQuantity.Text);
            string stockInStatus = "Stock";
            string stockInDate = DateTime.Now.ToShortDateString();

            StocksIn aStocksIn = new StocksIn();
            aStocksIn.ItemId = itemId;
            aStocksIn.StockInQuantity = stockInQuantity;
            aStocksIn.StockInStatus = stockInStatus;
            aStocksIn.StockInDate = stockInDate;

            StockManager aManager = new StockManager();
            string msg = aManager.SaveStockIn(aStocksIn);

            lblShow.Text = msg;
        }

        protected void btnWelcome_Click(object sender, EventArgs e)
        {

        }

        protected void btnCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategorySetup.aspx");
        }

        protected void btnComnpany_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanySetup.aspx");
        }

        protected void btnItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("ItemSetup.aspx");
        }

        protected void btnStockIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockIn.aspx");
        }

        protected void btnStockOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockOut.aspx");
        }

        protected void btnItemSummary_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewItemsSummary.aspx");
        }

        protected void btnSalesSummary_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSalesSummary.aspx");
        }
    }
}