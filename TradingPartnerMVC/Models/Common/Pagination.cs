using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TradingPartnerMVC.Models.Common
{
    public class Pagination
    {
        public double TotalRecords { get; set; }
        public int PageSize { get; set; }
        public double TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}