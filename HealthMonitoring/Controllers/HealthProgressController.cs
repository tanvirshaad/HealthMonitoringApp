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
        [HttpGet]
        [Route("api/healthprogress/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = HealthProgressService.GetProgress(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
