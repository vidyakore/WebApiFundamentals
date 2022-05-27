using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TheCodeCamp.Controllers
{
    public class OperationsController : ApiController
    {
        //creating functional API
        [HttpOptions]
        [Route("api/refreshconfig")]
        public IHttpActionResult RefreshAppSettings()
        {
            try
            {
                ConfigurationManager.RefreshSection("AppSetting");// refresh part of the Web.Config 
                return Ok();
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
            
        }
    }
}