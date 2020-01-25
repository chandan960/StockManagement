using StockManagement.DAL;
using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.BLL
{
    public class CompanyManager
    {
        public string SaveCompany(Company aCompany)
        {
            CompanysGateway gateway = new CompanysGateway();

            Company dbCompany = gateway.GetExistCompany(aCompany);
            if (dbCompany == null)
            {

                int rowAffected = gateway.SaveCompany(aCompany);

                if (rowAffected > 0)
                {
                    return "Save successfull";
                }

                return "Failed";
            }

            return "This Company Already Exist";
        }

        public List<Company> GetAllCompany()
        {
            CompanysGateway gateway = new CompanysGateway();
            return gateway.GetAllCompanys();
        }
    }
}