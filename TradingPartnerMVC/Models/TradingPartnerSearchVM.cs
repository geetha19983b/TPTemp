using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPartnerMVC.Models
{
    public class TradingPartnerSearchVM
    {
        public TradingPartnerSearchVM()
        {
            CurrentPage = 1;
            PageSize = 50;
            
        }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public int ID { get; set; }
        public string Customer { get; set; }
        public string CustomerNumber { get; set; }
    }
}