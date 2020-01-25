using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagement.DAL
{
    public class ItemsGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        public int SaveItem(Item aItem)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

            string query = "INSERT INTO tblItem Values(" + aItem.CategoryId + "," + aItem.CompanyId + ",'" + aItem.ItemName + "'," + aItem.ReorderLevel + ")";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }


        public List<Item> GetAllItem(int companyId)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT * FROM tblItem WHERE CompanyId = '" + companyId + "' ";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Item> itemList = new List<Item>();

            while (reader.Read())
            {
                Item item = new Item();
                item.ItemId = Convert.ToInt32(reader["ItemId"]);
                item.ItemName = reader["ItemName"].ToString();

                itemList.Add(item);
            }

            reader.Close();
            connection.Close();

            return itemList;

        }

        public int GetReorderLevel(int itemId)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT ReorderLevel FROM tblItem WHERE ItemId = '" + itemId + "' ";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Item item = new Item();
            while (reader.Read())
            {
                
                item.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"]);               
            }
            int ReorderLevel = item.ReorderLevel;

            reader.Close();
            connection.Close();

            return ReorderLevel;
        }


        public List<ItemSummaryView> GetItemSummaryList(int companyId , int categoryId)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
      
            string query = "SELECT Item.ItemName, Company.CompanyName, Category.CategoryName,Item.ReorderLevel FROM tblItem  AS Item, tblCompany AS Company ,tblCategory AS Category WHERE Item.CategoryId = Category.CategoryId AND Item.CompanyId=Company.CompanyId AND Item.CompanyId= '" + companyId + "' AND Item.CategoryId = '" + categoryId + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<ItemSummaryView> itemSummaryViewList = new List<ItemSummaryView>();

            while (reader.Read())
            {
                ItemSummaryView aItemSummaryView = new ItemSummaryView();
            
                aItemSummaryView.ItemName = reader["ItemName"].ToString();
                aItemSummaryView.CategoryName = reader["CategoryName"].ToString();
                aItemSummaryView.CompanyName = reader["CompanyName"].ToString();
                aItemSummaryView.ReorderLevel = Convert.ToInt32(reader["ReorderLevel"].ToString());

                itemSummaryViewList.Add(aItemSummaryView);
            }

            reader.Close();
            connection.Close();

            return itemSummaryViewList;
        }

        public Item GetExistItem(Item aItem)
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string query = "SELECT * FROM tblItem WHERE CategoryId = '" + aItem.CategoryId + "' AND CompanyId = '" + aItem.CompanyId + "' AND ItemName = '" + aItem.ItemName + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Item exisingItem = null;
            while (reader.Read())
            {
                exisingItem = new Item();
                exisingItem.CategoryId = Convert.ToInt32(reader["CategoryId"].ToString());
                exisingItem.CompanyId = Convert.ToInt32(reader["CompanyId"].ToString());
                exisingItem.ItemName = reader["ItemName"].ToString();
            }

            reader.Close();
            connection.Close();

            return exisingItem;
        }
    }
}