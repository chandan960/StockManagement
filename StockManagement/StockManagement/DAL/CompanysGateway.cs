using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagement.DAL
{
    public class CompanysGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        public int SaveCompany(Company aCompany)
        {
         //   string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

            string query = "INSERT INTO tblCompany Values('" + aCompany.CompanyName + "')";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public List<Company> GetAllCompanys()
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT * FROM tblCompany";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Company> companyList = new List<Company>();

            while (reader.Read())
            {
                Company aCompany = new Company();
                aCompany.CompanyId = Convert.ToInt32(reader["CompanyId"]);
                aCompany.CompanyName = reader["CompanyName"].ToString();

                companyList.Add(aCompany);
            }

            reader.Close();
            connection.Close();

            return companyList;
        }

        public Company GetExistCompany(Company aCompany)
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT * FROM tblCompany WHERE CompanyName = '" + aCompany.CompanyName + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Company exisingCompany = null;
            while (reader.Read())
            {
                exisingCompany = new Company();
                exisingCompany.CompanyName = reader["CompanyName"].ToString();
            }

            reader.Close();
            connection.Close();

            return exisingCompany;
        }
    }
}