using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPartnerMVC.Models
{
    public class FetchTradingPartner
    {
        public string customerName { get; set; }
        public string customerNumber { get; set; }

        public string FeedID { get; set; }
        public string statusInd { get; set; }
        public string vendor { get; set; }
        public string renewalMonth { get; set; }
        public int membershipCountStart { get; set; }
        public int membershipCountEnd { get; set; }
        public string lineOFBusiness { get; set; }
    }
}