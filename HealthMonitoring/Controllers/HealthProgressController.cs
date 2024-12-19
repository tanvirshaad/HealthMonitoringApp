using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HealthMonitoring.Controllers
{
    public class HealthProgressController : ApiController
    {
        [HttpPost]
        [Route("api/healthprogress")]
        public HttpResponseMessage Get(HealthProgressCheckDTO obj)
        {
            try
            {
                var data = HealthProgressService.GetProgress(obj.MetricType, obj.Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
