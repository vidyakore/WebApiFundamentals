using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TheCodeCamp.Data;
using TheCodeCamp.Models;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {
        private readonly ICampRepository _repository;
        private readonly IMapper _mapper;

        public CampsController(ICampRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: Camps
        public async Task<IHttpActionResult> Get()  //IHttpActionResult allows us to return both payloads and status codes
        {
            //return BadRequest("It's Okay");
            try
            {
                var result = await _repository.GetAllCampsAsync();

                //mapping
                var mappedResult = _mapper.Map<IEnumerable<CampModel>>(result);
                return Ok(mappedResult);
            }

            //return Ok(new { Name = "Shawn", Occupation = "Teacher" });
            catch(Exception ex)
            {
                //todo add Logging
                return InternalServerError(ex);
            }
            
        }
    }
}