using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Sie;
using kristen_mobile_data.Data.Models.Upqroo.Sie;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SieController : ControllerBase
    {
        private readonly ISieBusiness _apiBusiness;
        public SieController(ISieBusiness apiBusiness)
        {
            _apiBusiness = apiBusiness;
        }

        [HttpPost("/Login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginRequest request)
        {
            return Ok(await _apiBusiness.LoginAsync(request));
        }

        [HttpGet("/Grades/{studentId}")]
        public async Task<ActionResult<IEnumerable<Grade>>> GetGrades(string studentId, [FromQuery]string accessToken)
        {
            return Ok(await _apiBusiness.GetGradesAsync(studentId, accessToken));
        }

        [HttpGet("/Kardex/{studentId}")]
        public async Task<ActionResult<IEnumerable<Grade>>> GetKardex(string studentId, [FromQuery]string accessToken)
        {
            return Ok(await _apiBusiness.GetKardexsAsync(studentId, accessToken));
        }

        [HttpGet("/Schedule/{studentId}")]
        public async Task<ActionResult<IEnumerable<Grade>>> GetSchedule(string studentId, [FromQuery]string accessToken)
        {
            return Ok(await _apiBusiness.GetScheduleAsync(studentId, accessToken));
        }
    }
}
