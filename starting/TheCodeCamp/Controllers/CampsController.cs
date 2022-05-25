using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {
        // GET: Camps
        public IHttpActionResult Get()  //IHttpActionResult allows us to return both payloads and status codes
        {
            //return BadRequest("It's Okay");
            return Ok(new { Name = "Shawn", Occupation = "Teacher" });
        }
    }
}