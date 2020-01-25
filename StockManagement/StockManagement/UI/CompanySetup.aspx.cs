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
    public partial class CompanySetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            CompanyManager aManager = new CompanyManager();
            gridCompanys.DataSource = aManager.GetAllCompany();
            gridCompanys.DataBind();
        }

        protected void btnCompanySave_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;

            Company aCompany = new Company();
            aCompany.CompanyName = companyName;

            CompanyManager aManager = new CompanyManager();
            string msg = aManager.SaveCompany(aCompany);

            lblShow.Text = msg;
            Response.Redirect("CompanySetup.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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