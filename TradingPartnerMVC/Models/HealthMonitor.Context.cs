﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradingPartnerMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HealthMonitorEntities : DbContext
    {
        public HealthMonitorEntities()
            : base("name=HealthMonitorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<sp_FetchTradingPartnerData_TPM_Result> sp_FetchTradingPartnerData_TPM(string customerName, string customerNumber, string feedID, string statusInd, string vendor, string renewalMonth, Nullable<int> membershipCountStart, Nullable<int> membershipCountEnd, string lineOFBusiness, string fileType)
        {
            var customerNameParameter = customerName != null ?
                new ObjectParameter("customerName", customerName) :
                new ObjectParameter("customerName", typeof(string));
    
            var customerNumberParameter = customerNumber != null ?
                new ObjectParameter("customerNumber", customerNumber) :
                new ObjectParameter("customerNumber", typeof(string));
    
            var feedIDParameter = feedID != null ?
                new ObjectParameter("FeedID", feedID) :
                new ObjectParameter("FeedID", typeof(string));
    
            var statusIndParameter = statusInd != null ?
                new ObjectParameter("statusInd", statusInd) :
                new ObjectParameter("statusInd", typeof(string));
    
            var vendorParameter = vendor != null ?
                new ObjectParameter("vendor", vendor) :
                new ObjectParameter("vendor", typeof(string));
    
            var renewalMonthParameter = renewalMonth != null ?
                new ObjectParameter("renewalMonth", renewalMonth) :
                new ObjectParameter("renewalMonth", typeof(string));
    
            var membershipCountStartParameter = membershipCountStart.HasValue ?
                new ObjectParameter("membershipCountStart", membershipCountStart) :
                new ObjectParameter("membershipCountStart", typeof(int));
    
            var membershipCountEndParameter = membershipCountEnd.HasValue ?
                new ObjectParameter("membershipCountEnd", membershipCountEnd) :
                new ObjectParameter("membershipCountEnd", typeof(int));
    
            var lineOFBusinessParameter = lineOFBusiness != null ?
                new ObjectParameter("lineOFBusiness", lineOFBusiness) :
                new ObjectParameter("lineOFBusiness", typeof(string));
    
            var fileTypeParameter = fileType != null ?
                new ObjectParameter("fileType", fileType) :
                new ObjectParameter("fileType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_FetchTradingPartnerData_TPM_Result>("sp_FetchTradingPartnerData_TPM", customerNameParameter, customerNumberParameter, feedIDParameter, statusIndParameter, vendorParameter, renewalMonthParameter, membershipCountStartParameter, membershipCountEndParameter, lineOFBusinessParameter, fileTypeParameter);
        }
    
        public virtual ObjectResult<sp_FetchTradingPartnerDataById_TPM_Result> sp_FetchTradingPartnerDataById_TPM(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_FetchTradingPartnerDataById_TPM_Result>("sp_FetchTradingPartnerDataById_TPM", idParameter);
        }
    }
}