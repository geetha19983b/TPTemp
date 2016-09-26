using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TradingPartnerMVC.Controllers.Infrastructure;
using TradingPartnerMVC.Models;

namespace TradingPartnerMVC.Controllers.api
{
    [RoutePrefix("api/TradingService")]
    public class TradingServiceController : ApiControllerBase
    {
        HealthMonitorEntities healthEntities = new HealthMonitorEntities();
        public TradingServiceController()
        {

        }
        #region notneeded
        //[HttpGet]
        //[Route("TradingPartnerDetails/{id}")]
        //public HttpResponseMessage GetTradingPartnerDetails(HttpRequestMessage request, int id)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {


        //        HttpResponseMessage response = null;
        //        if (ModelState.IsValid)
        //        {

        //            var lstTPdetails = healthEntities.sp_FetchTradingPartnerDataById_TPM(id);

        //            response = request.CreateResponse<IEnumerable<sp_FetchTradingPartnerDataById_TPM_Result>>(HttpStatusCode.OK, lstTPdetails);
        //        }
        //        else
        //        {
        //            response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid request" });
        //        }
        //        return response;
        //    });
        //}
        //[HttpGet]

        //public HttpResponseMessage GetTradingPartner(HttpRequestMessage request, [FromUri] FetchTradingPartner tradingPartnerVM)
        //{
        //    if (tradingPartnerVM == null)
        //    {
        //        tradingPartnerVM = new FetchTradingPartner();
        //        tradingPartnerVM.customerName = " ";
        //        tradingPartnerVM.customerNumber = " ";
        //        tradingPartnerVM.FeedID = " ";
        //        tradingPartnerVM.statusInd = " ";
        //        tradingPartnerVM.vendor = " ";
        //        tradingPartnerVM.renewalMonth = " ";
        //        tradingPartnerVM.membershipCountStart = -1;
        //        tradingPartnerVM.membershipCountEnd = -1;
        //        tradingPartnerVM.lineOFBusiness = " ";
        //    }

        //    return CreateHttpResponse(request, () =>
        //    {


        //        HttpResponseMessage response = null;
        //        if (ModelState.IsValid)
        //        {
        //            //var lstTPdetails = healthEntities.sp_FetchTradingPartnerData_TPM(tradingPartnerVM.customerName,tradingPartnerVM.customerNumber,tradingPartnerVM.FeedID,tradingPartnerVM.statusInd,tradingPartnerVM.vendor,tradingPartnerVM.renewalMonth,tradingPartnerVM.membershipCountStart,tradingPartnerVM.membershipCountEnd,tradingPartnerVM.lineOFBusiness);
        //            var lstTPdetails = healthEntities.sp_FetchTradingPartnerData_TPM("", "", "", "", "", "", -1, -1, "", "");

        //            response = request.CreateResponse<IEnumerable<sp_FetchTradingPartnerData_TPM_Result>>(HttpStatusCode.OK, lstTPdetails);
        //        }
        //        else
        //        {
        //            response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid request" });
        //        }
        //        return response;
        //    });
        //} 
        #endregion

        [HttpGet]
        [Route("{ID}")]
        // [RequiresRouteValues("{addoncodeid}")]
        public HttpResponseMessage GETSingle(HttpRequestMessage request, int ID)
        {
            return CreateHttpResponse(request, () =>
            {

                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {

                    var lstTPdetails = healthEntities.sp_FetchTradingPartnerDataById_TPM(ID).FirstOrDefault();

                    response = request.CreateResponse<sp_FetchTradingPartnerDataById_TPM_Result>(HttpStatusCode.OK, lstTPdetails);
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid request" });
                }
                return response;


            });
        }

        [HttpPut]
       
        [Route("{ID}")]
        public HttpResponseMessage PUT(HttpRequestMessage request, sp_FetchTradingPartnerDataById_TPM_Result tpData)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;

               

                if (!ModelState.IsValid)
                {
                    if (response == null)
                    {
                        response = request.CreateResponse(HttpStatusCode.BadRequest,
                            ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                  .Select(m => new { Message = m.ErrorMessage }).ToArray());
                    }
                }
                else
                {
                    try
                    {
                        var benefind = tpData.BenefitFocusGroupInd == "Yes" ? true : false;
                        var pgind = tpData.PGInd == "Yes" ? true : false;
                        var lsttradingpartnerdetails = healthEntities.sp_UpdateTradingPartnerData_TPM(tpData.Customer,
                            tpData.CustomerNumber, tpData.CustomerEffectiveDate, tpData.CustomerTermDate,
                            tpData.RenewalMonth, tpData.FeedID, "iMStaffidParameter",
                             benefind, tpData.BenefitFocusMigrationDate,
                             pgind, tpData.PGTime, tpData.FeedType,
                             tpData.Frequency, tpData.ExpectedReceiptDay, tpData.ExpectedRunDay, tpData.FileType, tpData.FileFormat,
                             tpData.SpecialHandlingInstrc, tpData.Vendor, tpData.VendorEffectiveDate, tpData.VendorTermDate,
                              tpData.TrasnferMethod, tpData.FTPLogin, tpData.FTPPassword.ToString(), tpData.FTPFolder, tpData.StatusInd,
                               tpData.Status, tpData.DateVerified, tpData.Owner, tpData.OwnersComments,
                            tpData.CreatedUser, tpData.MainVendorContact, tpData.MainVendorPhone ?? "", tpData.MainVendorEmail,
                            tpData.SecondVendorName, tpData.SecondVendorPhone, tpData.SecondVendorEmail,
                            tpData.LineOfBusiness, tpData.AccountManager, tpData.BrokerName,
                            tpData.MembershipCount,"", tpData.FacetsMigrationDate, tpData.CustomProcess.ToString());

                        // customerParameter, customerNumberParameter, effectiveDateParameter, terminationDateParameter,
                        //renewalMonthParameter, feedIDParameter, iMStaffidParameter, 
                        //benefitFocusGroupIndParameter, benefitFocusMigrationDateParameter, pGIndParameter, pGTimeParameter,
                        //feed_typeParameter, frequencyParameter, expectedReceiptDayParameter, expectedRunDayParameter,
                        //fileTypeParameter, fileFormatParameter, specialHandlingInstrcParameter, vendorParameter, 
                        //vendorEffectiveDateParameter, vendorTerminationDateParameter, 
                        //transferMethodParameter, fTPLoginParameter, fTPPasswordParameter,
                        //fTPFolderParameter, statusIndParameter, statusParameter, dateVerifiedParameter, ownerParameter, 
                        //ownersCommentsParameter, userIdParameter, mainVendorContactParameter, mainVendorPhone_Parameter, mainVendorEmailParameter, 
                        //secondVendorNameParameter, secondVendorPhone_Parameter, secondVendorEmailParameter,
                        //line_of_businessParameter, accountManagerParameter, brokerParameter, 
                        //memberShipCountParameter, notesParameter, facetsMigrationdateParameter, customProcessParameter);                     

                        response = request.CreateResponse(HttpStatusCode.OK);
                    }
                    catch(Exception ex)
                    {
                        response = request.CreateResponse(HttpStatusCode.BadRequest, string.Join(ex.InnerException.ToString(), ex.Message.ToString()));
                    }
                }

                return response;
            });
        }

        [HttpGet]
        public HttpResponseMessage GetTradingPartner(HttpRequestMessage request, int CurrentPage = 1, int PageSize = 50)
        {


            return CreateHttpResponse(request, () =>
            {


                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {

                    var lstTPdetails = healthEntities.sp_FetchTradingPartnerData_TPM("", "", "", "", "", "", -1, -1, "", "")
                                       .OrderBy(x => x.ID)
                                       .Skip((Convert.ToInt32(CurrentPage - 1)) * Convert.ToInt32((PageSize)))
                                        .Take(PageSize).ToList();

                    var totalRecrds = healthEntities.sp_FetchTradingPartnerData_TPM("", "", "", "", "", "", -1, -1, "", "").Count();
                    List<FetchTradingPartner> lstTPResult = new List<FetchTradingPartner>
                    {
                        new FetchTradingPartner
                        {
                            CurrentPage = (Convert.ToInt32(CurrentPage)),
                            PageSize = Convert.ToInt32(PageSize),
                            TotalRecords =totalRecrds,
                            TotalPages = (int)Math.Ceiling((Convert.ToDecimal(totalRecrds) / Convert.ToDecimal(PageSize))),
                            TPResults = lstTPdetails
                        }
                    };

                    response = request.CreateResponse<IEnumerable<FetchTradingPartner>>(HttpStatusCode.OK, lstTPResult);
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid request" });
                }
                return response;
            });
        }
        [HttpGet]
        [Route("search")]
        public HttpResponseMessage Search(HttpRequestMessage request, [FromUri] TradingPartnerSearchVM tradingPartnerSeachVM)
        {
            if (tradingPartnerSeachVM == null)
            {
                tradingPartnerSeachVM = new TradingPartnerSearchVM();
            }

            return CreateHttpResponse(request, () =>
            {
              

                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var lstTPdetails = healthEntities.sp_FetchTradingPartnerData_TPM(tradingPartnerSeachVM.Customer, tradingPartnerSeachVM.CustomerNumber, "", "", "", "", -1, -1, "", "")
                                      .OrderBy(x => x.ID)
                                      .Skip((Convert.ToInt32(tradingPartnerSeachVM.CurrentPage - 1)) * Convert.ToInt32((tradingPartnerSeachVM.PageSize)))
                                       .Take(tradingPartnerSeachVM.PageSize).ToList();

                    var totalRecrds = healthEntities.sp_FetchTradingPartnerData_TPM(tradingPartnerSeachVM.Customer, tradingPartnerSeachVM.CustomerNumber, "", "", "", "", -1, -1, "", "").Count();
                    List<FetchTradingPartner> lstTPResult = new List<FetchTradingPartner>
                    {
                        new FetchTradingPartner
                        {
                            CurrentPage = (Convert.ToInt32(tradingPartnerSeachVM.CurrentPage)),
                            PageSize = Convert.ToInt32(tradingPartnerSeachVM.PageSize),
                            TotalRecords =totalRecrds,
                            TotalPages = (int)Math.Ceiling((Convert.ToDecimal(totalRecrds) / Convert.ToDecimal(tradingPartnerSeachVM.PageSize))),
                            TPResults = lstTPdetails
                        }
                    };

                    response = request.CreateResponse<IEnumerable<FetchTradingPartner>>(HttpStatusCode.OK, lstTPResult);
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid request" });
                }
                return response;
            });
        }
    }
}

