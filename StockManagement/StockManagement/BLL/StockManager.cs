using StockManagement.DAL;
using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.BLL
{
    public class StockManager
    {
        public int GetStockIn(int itemId)
        {
             StocksGateway gateway = new StocksGateway();
             return gateway.GetStockIn(itemId);
        }

        public int GetSell(int itemId)
        {
            StocksGateway gateway = new StocksGateway();
            return gateway.GetSell(itemId);
        }

        public int GetLost(int itemId)
        {
            StocksGateway gateway = new StocksGateway();
            return gateway.GetLost(itemId);
        }

        public int GetDamage(int itemId)
        {
            StocksGateway gateway = new StocksGateway();
            return gateway.GetDamage(itemId);
        }

        public string SaveStockIn(StocksIn aStocksIn)
        {
            StocksGateway gateway = new StocksGateway();

            int rowAffected = gateway.SaveStockIn(aStocksIn);

            if (rowAffected > 0)
            {
                return "Save successfull";
            }

            return "Failed";
        }

        public string UpdateStockOutSell()
        {
            StocksGateway gateway = new StocksGateway();
            StocksOut dbTemporryStockOut = gateway.GetExistTemporryStockOut();
            if (dbTemporryStockOut != null)
            {

                int rowAffected = gateway.UpdateStockOutSell();

                if (rowAffected > 0)
                {
                    return "Save successfull";
                }

                return "Failed";
            }
            return "No Data Added";
        }

        public string UpdateStockOutLost()
        {
            StocksGateway gateway = new StocksGateway();
            StocksOut dbTemporryStockOut = gateway.GetExistTemporryStockOut();
            if (dbTemporryStockOut != null)
            {
                int rowAffected = gateway.UpdateStockOutLost();

            if (rowAffected > 0)
            {
                return "Save successfull";
            }

            return "Failed";
            }
            return "No Data Added";
        }

        public string UpdateStockOutDamage()
        {
            StocksGateway gateway = new StocksGateway();
            StocksOut dbTemporryStockOut = gateway.GetExistTemporryStockOut();
            if (dbTemporryStockOut != null)
            {

                int rowAffected = gateway.UpdateStockOutDamage();

            if (rowAffected > 0)
            {
                return "Save successfull";
            }

            return "Failed";
        }
            return "No Data Added";
        }

        public string DeleteStockOut()
        {
            StocksGateway gateway = new StocksGateway();
            StocksOut dbTemporryStockOut = gateway.GetExistTemporryStockOut();
            if (dbTemporryStockOut != null)
            {

                int rowAffected = gateway.DeleteStockOut();

                if (rowAffected > 0)
                {
                    return "Delete successfull";
                }

                return "Failed";
            }
            return "No Data Added";
        }


        //public string SaveStockOutSell(StocksOut aStocksOutSell)
        //{
        //    StocksGateway gateway = new StocksGateway();

        //    int rowAffected = gateway.SaveStockOutSell(aStocksOutSell);

        //    if (rowAffected > 0)
        //    {
        //        return "Save successfull";
        //    }

        //    return "Failed";
        //}

        //public string SaveStockOutLost(StocksOut aStocksOutLost)
        //{
        //    StocksGateway gateway = new StocksGateway();

        //    int rowAffected = gateway.SaveStockOutLost(aStocksOutLost);

        //    if (rowAffected > 0)
        //    {
        //        return "Save successfull";
        //    }

        //    return "Failed";
        //}

        //public string SaveStockOutDamage(StocksOut aStocksOutDamage)
        //{
        //    StocksGateway gateway = new StocksGateway();

        //    int rowAffected = gateway.SaveStockOutDamage(aStocksOutDamage);

        //    if (rowAffected > 0)
        //    {
        //        return "Save successfull";
        //    }

        //    return "Failed";
        //}

        public List<SalesSummaryView> GetSalesSummaryList(string fromDate, string toDate)
        {
            StocksGateway gateway = new StocksGateway();

            return gateway.GetSalesSummaryList(fromDate, toDate);
        }

            public string SaveTemporyStockOut(StocksOut aTemporyStocksOut)
        {
            StocksGateway gateway = new StocksGateway();

            int rowAffected = gateway.SaveTemporyStockOut(aTemporyStocksOut);

            if (rowAffected > 0)
            {
                return "Save successfull";
            }

            return "Failed";
        }

        public List<TemporyStockOut> GetAllTemporyStockOut()
        {
            StocksGateway gateway = new StocksGateway();
            return gateway.GetAllTemporyStockOut();
        }
    }
}