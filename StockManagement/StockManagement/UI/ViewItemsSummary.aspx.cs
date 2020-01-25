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
    public partial class ViewItemsSummary : System.Web.UI.Page
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
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(ddCompanyId.SelectedValue);
            int categoryId = Convert.ToInt32(ddCategoryId.SelectedValue);

            BindDBItemsSummary(companyId , categoryId);
        }

        private void BindDBItemsSummary(int companyId , int categoryId)
        {
           
            ItemManager aManager = new ItemManager();
            gridViewItemSummary.DataSource = aManager.GetItemSummaryList(companyId , categoryId);
            gridViewItemSummary.DataBind();
        }

        protected void ddCompanyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(ddCompanyId.SelectedValue);
            BindDdCategory(companyId);
        }

        private void BindDdCategory(int companyId)
        {
            CategoryManager aManager = new CategoryManager();
            ddCategoryId.DataSource = aManager.GetCategoryList(companyId);
            ddCategoryId.DataBind();
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