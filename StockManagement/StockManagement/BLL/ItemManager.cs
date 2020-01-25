using StockManagement.DAL;
using StockManagement.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.BLL
{
    public class ItemManager
    {
        public string SaveItem(Item aItem)
        {
            ItemsGateway gateway = new ItemsGateway();

            Item dbItem = gateway.GetExistItem(aItem);
            if (dbItem == null)
            {
                int rowAffected = gateway.SaveItem(aItem);

                if (rowAffected > 0)
                {
                    return "Save successfull";
                }

                return "Failed";
            }

            return "This Item Already Exist";
        }

        public List<Item> GetItemList(int companyId)
        {
            ItemsGateway gateway = new ItemsGateway();
            return gateway.GetAllItem(companyId);
        }

    

        public int GetReOrderLevel(int itemId)
        {
            ItemsGateway gateway = new ItemsGateway();
            return gateway.GetReorderLevel(itemId);
        }

        public List<ItemSummaryView> GetItemSummaryList(int companyId, int categoryId)
        {
            ItemsGateway gateway = new ItemsGateway();
            return gateway.GetItemSummaryList(companyId, categoryId);
        }
    }
}