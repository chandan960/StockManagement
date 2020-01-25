using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagement.Modals
{
    public class TemporyStockOut
    {
        public string ItemName { get; set; }
        public string CompanyName { get; set; }
        public int StockOutQuantity { get; set; }
    }
}