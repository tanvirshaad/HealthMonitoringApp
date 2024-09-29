using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthMonitoring.Controllers
{
    public class TrendController : ApiController
    {
        [Route("api/trend/{id}")]
        [HttpGet]
        public HttpResponseMessage GetTrend(int id)
        {
            try
            {
                var data = TrendService.GetTrend(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
