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
    
        public virtual int sp_UpdateTradingPartnerData_TPM(string customer, string customerNumber, Nullable<System.DateTime> effectiveDate, Nullable<System.DateTime> terminationDate, string renewalMonth, string feedID, string iMStaffid, Nullable<bool> benefitFocusGroupInd, Nullable<System.DateTime> benefitFocusMigrationDate, Nullable<bool> pGInd, string pGTime, string feed_type, string frequency, string expectedReceiptDay, string expectedRunDay, string fileType, string fileFormat, string specialHandlingInstrc, string vendor, Nullable<System.DateTime> vendorEffectiveDate, Nullable<System.DateTime> vendorTerminationDate, string transferMethod, string fTPLogin, string fTPPassword, string fTPFolder, string statusInd, string status, Nullable<System.DateTime> dateVerified, string owner, string ownersComments, string userId, string mainVendorContact, string mainVendorPhone, string mainVendorEmail, string secondVendorName, string secondVendorPhone, string secondVendorEmail, string line_of_business, string accountManager, string broker, Nullable<int> memberShipCount, string notes, string facetsMigrationdate, string customProcess)
        {
            var customerParameter = customer != null ?
                new ObjectParameter("Customer", customer) :
                new ObjectParameter("Customer", typeof(string));
    
            var customerNumberParameter = customerNumber != null ?
                new ObjectParameter("CustomerNumber", customerNumber) :
                new ObjectParameter("CustomerNumber", typeof(string));
    
            var effectiveDateParameter = effectiveDate.HasValue ?
                new ObjectParameter("EffectiveDate", effectiveDate) :
                new ObjectParameter("EffectiveDate", typeof(System.DateTime));
    
            var terminationDateParameter = terminationDate.HasValue ?
                new ObjectParameter("TerminationDate", terminationDate) :
                new ObjectParameter("TerminationDate", typeof(System.DateTime));
    
            var renewalMonthParameter = renewalMonth != null ?
                new ObjectParameter("RenewalMonth", renewalMonth) :
                new ObjectParameter("RenewalMonth", typeof(string));
    
            var feedIDParameter = feedID != null ?
                new ObjectParameter("FeedID", feedID) :
                new ObjectParameter("FeedID", typeof(string));
    
            var iMStaffidParameter = iMStaffid != null ?
                new ObjectParameter("IMStaffid", iMStaffid) :
                new ObjectParameter("IMStaffid", typeof(string));
    
            var benefitFocusGroupIndParameter = benefitFocusGroupInd.HasValue ?
                new ObjectParameter("BenefitFocusGroupInd", benefitFocusGroupInd) :
                new ObjectParameter("BenefitFocusGroupInd", typeof(bool));
    
            var benefitFocusMigrationDateParameter = benefitFocusMigrationDate.HasValue ?
                new ObjectParameter("BenefitFocusMigrationDate", benefitFocusMigrationDate) :
                new ObjectParameter("BenefitFocusMigrationDate", typeof(System.DateTime));
    
            var pGIndParameter = pGInd.HasValue ?
                new ObjectParameter("PGInd", pGInd) :
                new ObjectParameter("PGInd", typeof(bool));
    
            var pGTimeParameter = pGTime != null ?
                new ObjectParameter("PGTime", pGTime) :
                new ObjectParameter("PGTime", typeof(string));
    
            var feed_typeParameter = feed_type != null ?
                new ObjectParameter("feed_type", feed_type) :
                new ObjectParameter("feed_type", typeof(string));
    
            var frequencyParameter = frequency != null ?
                new ObjectParameter("Frequency", frequency) :
                new ObjectParameter("Frequency", typeof(string));
    
            var expectedReceiptDayParameter = expectedReceiptDay != null ?
                new ObjectParameter("ExpectedReceiptDay", expectedReceiptDay) :
                new ObjectParameter("ExpectedReceiptDay", typeof(string));
    
            var expectedRunDayParameter = expectedRunDay != null ?
                new ObjectParameter("ExpectedRunDay", expectedRunDay) :
                new ObjectParameter("ExpectedRunDay", typeof(string));
    
            var fileTypeParameter = fileType != null ?
                new ObjectParameter("FileType", fileType) :
                new ObjectParameter("FileType", typeof(string));
    
            var fileFormatParameter = fileFormat != null ?
                new ObjectParameter("FileFormat", fileFormat) :
                new ObjectParameter("FileFormat", typeof(string));
    
            var specialHandlingInstrcParameter = specialHandlingInstrc != null ?
                new ObjectParameter("SpecialHandlingInstrc", specialHandlingInstrc) :
                new ObjectParameter("SpecialHandlingInstrc", typeof(string));
    
            var vendorParameter = vendor != null ?
                new ObjectParameter("Vendor", vendor) :
                new ObjectParameter("Vendor", typeof(string));
    
            var vendorEffectiveDateParameter = vendorEffectiveDate.HasValue ?
                new ObjectParameter("VendorEffectiveDate", vendorEffectiveDate) :
                new ObjectParameter("VendorEffectiveDate", typeof(System.DateTime));
    
            var vendorTerminationDateParameter = vendorTerminationDate.HasValue ?
                new ObjectParameter("VendorTerminationDate", vendorTerminationDate) :
                new ObjectParameter("VendorTerminationDate", typeof(System.DateTime));
    
            var transferMethodParameter = transferMethod != null ?
                new ObjectParameter("TransferMethod", transferMethod) :
                new ObjectParameter("TransferMethod", typeof(string));
    
            var fTPLoginParameter = fTPLogin != null ?
                new ObjectParameter("FTPLogin", fTPLogin) :
                new ObjectParameter("FTPLogin", typeof(string));
    
            var fTPPasswordParameter = fTPPassword != null ?
                new ObjectParameter("FTPPassword", fTPPassword) :
                new ObjectParameter("FTPPassword", typeof(string));
    
            var fTPFolderParameter = fTPFolder != null ?
                new ObjectParameter("FTPFolder", fTPFolder) :
                new ObjectParameter("FTPFolder", typeof(string));
    
            var statusIndParameter = statusInd != null ?
                new ObjectParameter("StatusInd", statusInd) :
                new ObjectParameter("StatusInd", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            var dateVerifiedParameter = dateVerified.HasValue ?
                new ObjectParameter("DateVerified", dateVerified) :
                new ObjectParameter("DateVerified", typeof(System.DateTime));
    
            var ownerParameter = owner != null ?
                new ObjectParameter("Owner", owner) :
                new ObjectParameter("Owner", typeof(string));
    
            var ownersCommentsParameter = ownersComments != null ?
                new ObjectParameter("OwnersComments", ownersComments) :
                new ObjectParameter("OwnersComments", typeof(string));
    
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var mainVendorContactParameter = mainVendorContact != null ?
                new ObjectParameter("MainVendorContact", mainVendorContact) :
                new ObjectParameter("MainVendorContact", typeof(string));
    
            var mainVendorPhoneParameter = mainVendorPhone != null ?
                new ObjectParameter("MainVendorPhone", mainVendorPhone) :
                new ObjectParameter("MainVendorPhone", typeof(string));
    
            var mainVendorEmailParameter = mainVendorEmail != null ?
                new ObjectParameter("MainVendorEmail", mainVendorEmail) :
                new ObjectParameter("MainVendorEmail", typeof(string));
    
            var secondVendorNameParameter = secondVendorName != null ?
                new ObjectParameter("SecondVendorName", secondVendorName) :
                new ObjectParameter("SecondVendorName", typeof(string));
    
            var secondVendorPhoneParameter = secondVendorPhone != null ?
                new ObjectParameter("SecondVendorPhone", secondVendorPhone) :
                new ObjectParameter("SecondVendorPhone", typeof(string));
    
            var secondVendorEmailParameter = secondVendorEmail != null ?
                new ObjectParameter("SecondVendorEmail", secondVendorEmail) :
                new ObjectParameter("SecondVendorEmail", typeof(string));
    
            var line_of_businessParameter = line_of_business != null ?
                new ObjectParameter("line_of_business", line_of_business) :
                new ObjectParameter("line_of_business", typeof(string));
    
            var accountManagerParameter = accountManager != null ?
                new ObjectParameter("AccountManager", accountManager) :
                new ObjectParameter("AccountManager", typeof(string));
    
            var brokerParameter = broker != null ?
                new ObjectParameter("Broker", broker) :
                new ObjectParameter("Broker", typeof(string));
    
            var memberShipCountParameter = memberShipCount.HasValue ?
                new ObjectParameter("MemberShipCount", memberShipCount) :
                new ObjectParameter("MemberShipCount", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            var facetsMigrationdateParameter = facetsMigrationdate != null ?
                new ObjectParameter("FacetsMigrationdate", facetsMigrationdate) :
                new ObjectParameter("FacetsMigrationdate", typeof(string));
    
            var customProcessParameter = customProcess != null ?
                new ObjectParameter("CustomProcess", customProcess) :
                new ObjectParameter("CustomProcess", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateTradingPartnerData_TPM", customerParameter, customerNumberParameter, effectiveDateParameter, terminationDateParameter, renewalMonthParameter, feedIDParameter, iMStaffidParameter, benefitFocusGroupIndParameter, benefitFocusMigrationDateParameter, pGIndParameter, pGTimeParameter, feed_typeParameter, frequencyParameter, expectedReceiptDayParameter, expectedRunDayParameter, fileTypeParameter, fileFormatParameter, specialHandlingInstrcParameter, vendorParameter, vendorEffectiveDateParameter, vendorTerminationDateParameter, transferMethodParameter, fTPLoginParameter, fTPPasswordParameter, fTPFolderParameter, statusIndParameter, statusParameter, dateVerifiedParameter, ownerParameter, ownersCommentsParameter, userIdParameter, mainVendorContactParameter, mainVendorPhoneParameter, mainVendorEmailParameter, secondVendorNameParameter, secondVendorPhoneParameter, secondVendorEmailParameter, line_of_businessParameter, accountManagerParameter, brokerParameter, memberShipCountParameter, notesParameter, facetsMigrationdateParameter, customProcessParameter);
        }
    }
}
