using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.Modals
{
    public class StocksOut
    {
        public int StockOutId { get; set; }
        public int ItemId { get; set; }
        public int CompanyId { get; set; }
        public int StockOutQuantity { get; set; }
        public string StockOutStatus { get; set; }
        public string StockOutDate { get; set; }
    }
}