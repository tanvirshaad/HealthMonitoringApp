using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthMonitoring.Controllers
{
    public class StatController : ApiController
    {
        [Route("api/stat/{id}")]
        [HttpGet]
        public HttpResponseMessage GetStat(int id)
        {
            try
            {
                var data = StatService.GetStats(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
