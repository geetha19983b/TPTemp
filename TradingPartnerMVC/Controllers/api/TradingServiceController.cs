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
    [RoutePrefix("api/TradingPartner")]
    public class TradingServiceController : ApiControllerBase
    {
        HealthMonitorEntities healthEntities = new HealthMonitorEntities();
        public TradingServiceController()
        {
            
        }
        [HttpGet]
        [Route("TradingPartnerDetails/{id}")]
        public HttpResponseMessage GetTradingPartnerDetails(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {


                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {

                    var lstTPdetails = healthEntities.sp_FetchTradingPartnerDataById_TPM(id);

                    response = request.CreateResponse<IEnumerable<sp_FetchTradingPartnerDataById_TPM_Result>>(HttpStatusCode.OK, lstTPdetails);
                }
                else
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid request" });
                }
                return response;
            });
        }
        [HttpGet]

        public HttpResponseMessage GetTradingPartner(HttpRequestMessage request, [FromUri] FetchTradingPartner tradingPartnerVM)
        {
            if (tradingPartnerVM == null)
            {
                tradingPartnerVM = new FetchTradingPartner();
                tradingPartnerVM.customerName = " ";
                tradingPartnerVM.customerNumber = " ";
                tradingPartnerVM.FeedID = " ";
                tradingPartnerVM.statusInd = " ";
                tradingPartnerVM.vendor = " ";
                tradingPartnerVM.renewalMonth = " ";
                tradingPartnerVM.membershipCountStart = -1;
                tradingPartnerVM.membershipCountEnd = -1;
                tradingPartnerVM.lineOFBusiness = " ";
            }

            return CreateHttpResponse(request, () =>
            {
               

                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    //var lstTPdetails = healthEntities.sp_FetchTradingPartnerData_TPM(tradingPartnerVM.customerName,tradingPartnerVM.customerNumber,tradingPartnerVM.FeedID,tradingPartnerVM.statusInd,tradingPartnerVM.vendor,tradingPartnerVM.renewalMonth,tradingPartnerVM.membershipCountStart,tradingPartnerVM.membershipCountEnd,tradingPartnerVM.lineOFBusiness);
                    var lstTPdetails = healthEntities.sp_FetchTradingPartnerData_TPM("", "", "", "", "", "", -1, -1, "", "");

                    response = request.CreateResponse<IEnumerable<sp_FetchTradingPartnerData_TPM_Result>>(HttpStatusCode.OK, lstTPdetails);
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

