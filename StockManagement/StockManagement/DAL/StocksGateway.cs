using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace StockManagement.DAL
{
    public class StocksGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        public int GetStockIn(int itemId)
        {
            //string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string status = "Stock";
            string query = "SELECT StockInQuantity FROM tblStockIn WHERE ItemId = '" + itemId + "' AND StockInStatus = '" + status + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StocksIn stockIn = new StocksIn();
            int quantity = 0;
            while (reader.Read())
            {

                stockIn.StockInQuantity = Convert.ToInt32(reader["StockInQuantity"]);
                quantity = quantity + stockIn.StockInQuantity;
                
            }

            reader.Close();
            connection.Close();

            return quantity;
        }


        public int GetSell(int itemId)
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string status = "Sell";
            string query = "SELECT StockOutQuantity FROM tblStockOut WHERE ItemId = '" + itemId + "' AND StockOutStatus = '" + status + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StocksOut stockOut = new StocksOut();
            int quantity = 0;
            while (reader.Read())
            {

                stockOut.StockOutQuantity = Convert.ToInt32(reader["StockOutQuantity"]);
                quantity = quantity + stockOut.StockOutQuantity;

            }

            reader.Close();
            connection.Close();

            return quantity;
        }


        public int GetLost(int itemId)
        {
            //string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string status = "Lost";
            string query = "SELECT StockOutQuantity FROM tblStockOut WHERE ItemId = '" + itemId + "' AND StockOutStatus = '" + status + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StocksOut stockOut = new StocksOut();
            int quantity = 0;
            while (reader.Read())
            {

                stockOut.StockOutQuantity = Convert.ToInt32(reader["StockOutQuantity"]);
                quantity = quantity + stockOut.StockOutQuantity;

            }

            reader.Close();
            connection.Close();

            return quantity;
        }


        public int GetDamage(int itemId)
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string status = "Damage";
            string query = "SELECT StockOutQuantity FROM tblStockOut WHERE ItemId = '" + itemId + "' AND StockOutStatus = '" + status + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StocksOut stockOut = new StocksOut();
            int quantity = 0;
            while (reader.Read())
            {

                stockOut.StockOutQuantity = Convert.ToInt32(reader["StockOutQuantity"]);
                quantity = quantity + stockOut.StockOutQuantity;

            }

            reader.Close();
            connection.Close();

            return quantity;
        }

        public int SaveStockIn(StocksIn aStocksIn)
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

            string query = "INSERT INTO tblStockIn Values('" + aStocksIn.ItemId + "' ,'" + aStocksIn.StockInQuantity + "' , '" + aStocksIn.StockInStatus + "' , '" + aStocksIn.StockInDate + "')";

           SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public int UpdateStockOutSell()
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string tempStockOutStatus = "Temporry";
            string finalStockOutStatus = "Sell";

            string query = "UPDATE tblStockOut SET StockOutStatus = '" + finalStockOutStatus + "' WHERE StockOutStatus = '" + tempStockOutStatus + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public int UpdateStockOutLost()
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string tempStockOutStatus = "Temporry";
            string finalStockOutStatus = "Lost";
            string query = "UPDATE tblStockOut SET StockOutStatus = '" + finalStockOutStatus + "' WHERE StockOutStatus = '" + tempStockOutStatus + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }

        public int UpdateStockOutDamage()
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string tempStockOutStatus = "Temporry";
            string finalStockOutStatus = "Damage";
            string query = "UPDATE tblStockOut SET StockOutStatus = '" + finalStockOutStatus + "' WHERE StockOutStatus = '" + tempStockOutStatus + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }


        public int DeleteStockOut()
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string StockOutStatus = "Temporry";
            string query = "Delete from tblStockOut Where StockOutStatus='" + StockOutStatus + "'";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }


        //public int SaveStockOutSell(StocksOut aStocksOutSell)
        //{
        //    string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

        //    string query = "INSERT INTO tblStockOut Values('" + aStocksOutSell.ItemId + "' ,'" + aStocksOutSell.StockOutQuantity + "' , '" + aStocksOutSell.StockOutStatus + "' , '" + aStocksOutSell.StockOutDate + "')";

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    SqlCommand command = new SqlCommand(query, connection);

        //    connection.Open();
        //    int rowAffected = command.ExecuteNonQuery();
        //    connection.Close();

        //    return rowAffected;
        //}

        //public int SaveStockOutLost(StocksOut aStocksOutLost)
        //{
        //    string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

        //    string query = "INSERT INTO tblStockOut Values('" + aStocksOutLost.ItemId + "' ,'" + aStocksOutLost.StockOutQuantity + "' , '" + aStocksOutLost.StockOutStatus + "' , '" + aStocksOutLost.StockOutDate + "')";

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    SqlCommand command = new SqlCommand(query, connection);

        //    connection.Open();
        //    int rowAffected = command.ExecuteNonQuery();
        //    connection.Close();

        //    return rowAffected;
        //}

        //public int SaveStockOutDamage(StocksOut aStocksOutDamage)
        //{
        //    string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

        //    string query = "INSERT INTO tblStockOut Values('" + aStocksOutDamage.ItemId + "' ,'" + aStocksOutDamage.StockOutQuantity + "' , '" + aStocksOutDamage.StockOutStatus + "' , '" + aStocksOutDamage.StockOutDate + "')";

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    SqlCommand command = new SqlCommand(query, connection);

        //    connection.Open();
        //    int rowAffected = command.ExecuteNonQuery();
        //    connection.Close();

        //    return rowAffected;
        //}

        public List<SalesSummaryView> GetSalesSummaryList(string fromDate, string toDate)
        {
           // string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string salesStatus = "Sell";
            string query = "SELECT Item.ItemName , StockOut.StockOutQuantity FROM tblItem AS Item , tblStockOut AS StockOut WHERE Item.ItemId = StockOut.ItemId AND StockOut.StockOutStatus = '" + salesStatus + "' AND StockOut.StockOutDate >= '" + fromDate + "' AND StockOut.StockOutDate <= '" + toDate + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<SalesSummaryView> salesSummaryViewList = new List<SalesSummaryView>();

            while (reader.Read())
            {
                SalesSummaryView aSalesSummaryView = new SalesSummaryView();

                aSalesSummaryView.ItemName = reader["ItemName"].ToString();
                aSalesSummaryView.StockOutQuantity = Convert.ToInt32(reader["StockOutQuantity"].ToString());

                salesSummaryViewList.Add(aSalesSummaryView);
            }

            reader.Close();
            connection.Close();

            return salesSummaryViewList;
        }

        public int SaveTemporyStockOut(StocksOut aTemporyStocksOut)
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";

            // string query = "INSERT INTO tblTemporryStockOut Values('" + aTemporyStocksOut.ItemId + "' ,'" + aTemporyStocksOut.StockOutQuantity + "' , '" + aTemporyStocksOut.CompanyId + "')";
            string query = "INSERT INTO tblStockOut Values('" + aTemporyStocksOut.ItemId + "' ,'" + aTemporyStocksOut.StockOutQuantity + "' , '" + aTemporyStocksOut.StockOutStatus + "' , '" + aTemporyStocksOut.StockOutDate + "')";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }


        public List<TemporyStockOut> GetAllTemporyStockOut()
        {
          //  string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string salesStatus = "Temporry";
            string query = "SELECT Item.ItemName , StockOut.StockOutQuantity , Company.CompanyName FROM tblItem AS Item  , tblCompany AS Company,tblStockOut AS StockOut Where StockOut.ItemId = Item.ItemId AND Company.CompanyId =Item.CompanyId AND StockOut.StockOutStatus = '" + salesStatus + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<TemporyStockOut> temporyStockOutList = new List<TemporyStockOut>();

            while (reader.Read())
            {
                TemporyStockOut aTemporyStockOut = new TemporyStockOut();
                aTemporyStockOut.ItemName = reader["ItemName"].ToString();
                aTemporyStockOut.CompanyName = reader["CompanyName"].ToString();
                aTemporyStockOut.StockOutQuantity = Convert.ToInt32(reader["StockOutQuantity"]);

                temporyStockOutList.Add(aTemporyStockOut);
            }

            reader.Close();
            connection.Close();

            return temporyStockOutList;
        }

        public StocksOut GetExistTemporryStockOut()
        {
            //string connectionString = @"Server=DESKTOP-0S251U4;Database = DBStockManagement;Integrated Security=true";
            string stockOutStatus = "Temporry";
            string query = "SELECT StockOutStatus FROM tblStockOut WHERE StockOutStatus = '" + stockOutStatus + "'";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StocksOut existTemporryStockOut = null;
            while (reader.Read())
            {
                existTemporryStockOut = new StocksOut();
                existTemporryStockOut.StockOutStatus = reader["StockOutStatus"].ToString();
            }

            reader.Close();
            connection.Close();

            return existTemporryStockOut;
        }
    }
}