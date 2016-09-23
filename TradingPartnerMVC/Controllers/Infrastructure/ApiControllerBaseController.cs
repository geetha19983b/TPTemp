using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TradingPartnerMVC.Controllers.Infrastructure
{
    public class ApiControllerBase : ApiController
    {
        protected string RegionID;
        protected string RequestedUserID;

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage request, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage response = null;

          
            try
            {
                response = function.Invoke();
            }
            catch (DbUpdateException ex)
            {
                //LogError(ex);
                response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message, Details = ex.InnerException.Message });
            }
            catch (DbEntityValidationException ex)
            {
                response = request.CreateResponse(HttpStatusCode.BadRequest, new { Message = ex.Message, Details = ex.InnerException.Message });
            }
            catch (AggregateException ex)
            {
              
                response = request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Details = ex.InnerException.Message });
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    response = request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Details = ex.InnerException.Message });
                }
                else
                {
                    
                    response = request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
                }
            }

            return response;
        }
    }
}
