using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagement.DAL
{
    public class CategorysGateway
    {
        //private string connectionString;
        private string connectionString = WebConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        public int SaveCategory(Category aCategory)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

            string query = "INSERT INTO tblCategory Values('" + aCategory.CategoryName + "')";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public List<Category> GetAllCategorys()
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT * FROM tblCategory";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Category> categoryList = new List<Category>();

            while (reader.Read())
            {
                Category aCategory = new Category();
                aCategory.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                aCategory.CategoryName = reader["CategoryName"].ToString();

                categoryList.Add(aCategory);
            }

            reader.Close();
            connection.Close();

            return categoryList;
        }


        public List<Category> GetAllCategory(int companyId)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT DISTINCT tblCategory.CategoryId , tblCategory.CategoryName FROM tblItem INNER JOIN tblCategory ON tblItem.CategoryId = tblCategory.CategoryId WHERE tblItem.CompanyId = '" + companyId + "' ";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Category> categoryList = new List<Category>();

            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                category.CategoryName = reader["CategoryName"].ToString();

                categoryList.Add(category);
            }

            reader.Close();
            connection.Close();

            return categoryList;

        }


        public Category GetExistCategory(Category aCategory)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT * FROM tblCategory WHERE CategoryName = '" + aCategory.CategoryName + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Category exisingCategory = null;
            while (reader.Read())
            {
                exisingCategory = new Category();
                exisingCategory.CategoryName = reader["CategoryName"].ToString();
            }

            reader.Close();
            connection.Close();

            return exisingCategory;
        }


    }
}