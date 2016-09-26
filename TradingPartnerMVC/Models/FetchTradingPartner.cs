using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradingPartnerMVC.Models.Common;

namespace TradingPartnerMVC.Models
{
    public class FetchTradingPartner :Pagination
    {
        public List<sp_FetchTradingPartnerData_TPM_Result> TPResults { get; set; }
    }
}