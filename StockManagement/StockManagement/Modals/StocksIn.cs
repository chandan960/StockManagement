using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.Modals
{
    public class StocksIn
    {
        public int StockInId { get; set; }
        public int ItemId { get; set; }
        public int StockInQuantity { get; set; }
        public string StockInStatus { get; set; }
        public string StockInDate { get; set; }
    }
}