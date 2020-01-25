using StockManagement.DAL;
using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.BLL
{
    public class CategoryManager
    {
        public string SaveCategory(Category aCategory)
        {
            CategorysGateway gateway = new CategorysGateway();

            Category dbCategory = gateway.GetExistCategory(aCategory);
            if (dbCategory == null)
            { 
            int rowAffected = gateway.SaveCategory(aCategory);

            if (rowAffected > 0)
            {
                return "Save successfull";
            }

            return "Failed";
        }
            return "This Category Already Exist";
        }

        public List<Category> GetAllCategory()
        {
            CategorysGateway gateway = new CategorysGateway();
            return gateway.GetAllCategorys();
        }

        public List<Category> GetCategoryList(int companyId)
        {
            CategorysGateway gateway = new CategorysGateway();
            return gateway.GetAllCategory(companyId);
        }
    }

   
}