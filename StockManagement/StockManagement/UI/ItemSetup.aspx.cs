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
    public partial class ItemSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDdCategory();
                BindDdCompany();
            }
        }

        private void BindDdCategory()
        {
            CategoryManager aManager = new CategoryManager();
            ddCategoryId.DataSource = aManager.GetAllCategory();
            ddCategoryId.DataBind();
        }

        private void BindDdCompany()
        {
            CompanyManager aManager = new CompanyManager();
            ddCompanyId.DataSource = aManager.GetAllCompany();
            ddCompanyId.DataBind();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(ddCategoryId.SelectedValue);
            int companyId = Convert.ToInt32(ddCompanyId.SelectedValue);
            string itemName = txtItemName.Text;
            int reorderLevel = Convert.ToInt32(txtReorderLevel.Text);

            Item aItem = new Item();
            aItem.CategoryId = categoryId;
            aItem.CompanyId = companyId;
            aItem.ItemName = itemName;
            aItem.ReorderLevel = reorderLevel;

            ItemManager aManager = new ItemManager();
            string msg = aManager.SaveItem(aItem);

            lblShow.Text = msg;
        }

        protected void btnWelcome_Click(object sender, EventArgs e)
        {

        }

        protected void btnWelcome_Click1(object sender, EventArgs e)
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