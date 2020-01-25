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
    public partial class StockOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDdCompany();
            }

            BindDbTemporyStockOut();
        }

        private void BindDbTemporyStockOut()
        {
            StockManager aManager = new StockManager();
            gridViewTemporyStockOut.DataSource = aManager.GetAllTemporyStockOut();
            gridViewTemporyStockOut.DataBind();
        }


        private void BindDdCompany()
        {
            CompanyManager aManager = new CompanyManager();
            ddCompanyId.DataSource = aManager.GetAllCompany();
            ddCompanyId.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //int companyId = Convert.ToInt32(ddCompanyId.SelectedValue);
            //int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            //int stockOutQuantity = Convert.ToInt32(txtStockOutQuantity.Text);

            //StocksOut aTemporyStocksOut = new StocksOut();
            //aTemporyStocksOut.CompanyId = companyId;
            //aTemporyStocksOut.ItemId = itemId;
            //aTemporyStocksOut.StockOutQuantity = stockOutQuantity;

            //StockManager aManager = new StockManager();
            //string msg = aManager.SaveTemporyStockOut(aTemporyStocksOut);

            //lblShow.Text = msg;

            int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            int stockOutQuantity = Convert.ToInt32(txtStockOutQuantity.Text);
            string stockOutStatus = "Temporry";
            string stockOutDate = DateTime.Now.ToShortDateString();

            StocksOut aTemporyStocksOut = new StocksOut();
            aTemporyStocksOut.ItemId = itemId;
            aTemporyStocksOut.StockOutQuantity = stockOutQuantity;
            aTemporyStocksOut.StockOutStatus = stockOutStatus;
            aTemporyStocksOut.StockOutDate = stockOutDate;

            StockManager aManager = new StockManager();
            string msg = aManager.SaveTemporyStockOut(aTemporyStocksOut);

            lblShow.Text = msg;
            Response.Redirect("StockOut.aspx");
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

        protected void btnSell_Click(object sender, EventArgs e)
        {
            //int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            //int stockOutQuantity = Convert.ToInt32(txtStockOutQuantity.Text);
            //string stockOutStatus = "Sell";
            //string stockOutDate = DateTime.Now.ToShortDateString();

            //StocksOut aStocksOutSell = new StocksOut();
            //aStocksOutSell.ItemId = itemId;
            //aStocksOutSell.StockOutQuantity = stockOutQuantity;
            //aStocksOutSell.StockOutStatus = stockOutStatus;
            //aStocksOutSell.StockOutDate = stockOutDate;

            //StockManager aManager = new StockManager();
            //string msg = aManager.SaveStockOutSell(aStocksOutSell);

            //lblShow.Text = msg;

            StockManager aManager = new StockManager();
            string msg = aManager.UpdateStockOutSell();

            lblShow.Text = msg;
            Response.Redirect("StockOut.aspx");
        }

        protected void btnLost_Click(object sender, EventArgs e)
        {
            //int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            //int stockOutQuantity = Convert.ToInt32(txtStockOutQuantity.Text);
            //string stockOutStatus = "Lost";
            //string stockOutDate = DateTime.Now.ToShortDateString();

            //StocksOut aStocksOutLost = new StocksOut();
            //aStocksOutLost.ItemId = itemId;
            //aStocksOutLost.StockOutQuantity = stockOutQuantity;
            //aStocksOutLost.StockOutStatus = stockOutStatus;
            //aStocksOutLost.StockOutDate = stockOutDate;

            //StockManager aManager = new StockManager();
            //string msg = aManager.SaveStockOutLost(aStocksOutLost);

            //lblShow.Text = msg;

            StockManager aManager = new StockManager();
            string msg = aManager.UpdateStockOutLost();

            lblShow.Text = msg;
            Response.Redirect("StockOut.aspx");
        }

        protected void btnDamage_Click(object sender, EventArgs e)
        {
            //int itemId = Convert.ToInt32(ddItemId.SelectedValue);
            //int stockOutQuantity = Convert.ToInt32(txtStockOutQuantity.Text);
            //string stockOutStatus = "Damage";
            //string stockOutDate = DateTime.Now.ToShortDateString();

            //StocksOut aStocksOutDamage = new StocksOut();
            //aStocksOutDamage.ItemId = itemId;
            //aStocksOutDamage.StockOutQuantity = stockOutQuantity;
            //aStocksOutDamage.StockOutStatus = stockOutStatus;
            //aStocksOutDamage.StockOutDate = stockOutDate;

            //StockManager aManager = new StockManager();
            //string msg = aManager.SaveStockOutDamage(aStocksOutDamage);

            //lblShow.Text = msg;

            StockManager aManager = new StockManager();
            string msg = aManager.UpdateStockOutDamage();

            lblShow.Text = msg;
            Response.Redirect("StockOut.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            StockManager aManager = new StockManager();
            string msg = aManager.DeleteStockOut();

            lblShow.Text = msg;
            Response.Redirect("StockOut.aspx");
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