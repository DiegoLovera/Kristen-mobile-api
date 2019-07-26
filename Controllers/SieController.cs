using kristen_mobile_api.Business.Exceptions;
using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Data.Models;
using kristen_mobile_api.Data.Models.Upqroo.Sie;
using kristen_mobile_data.Data.Models.Upqroo.Sie;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kristen_mobile_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SieController : KristenBaseController
    {
        private readonly ISieBusiness _apiBusiness;
        public SieController(ISieBusiness apiBusiness)
        {
            _apiBusiness = apiBusiness;
        }

        [HttpPost("/Login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginRequest request)
        {
            try
            {
                return Ok(await _apiBusiness.LoginAsync(request));
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/Grades/{studentId}")]
        public async Task<ActionResult<IEnumerable<Grade>>> GetGrades(string studentId, [FromQuery]string accessToken)
        {
            try
            {
                return Ok(await _apiBusiness.GetGradesAsync(studentId, accessToken));
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/Kardex/{studentId}")]
        public async Task<ActionResult<IEnumerable<Kardex>>> GetKardex(string studentId, [FromQuery]string accessToken)
        {
            try
            {
                return Ok(await _apiBusiness.GetKardexsAsync(studentId, accessToken));
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/Schedule/{studentId}")]
        public async Task<ActionResult<Week>> GetSchedule(string studentId, [FromQuery]string accessToken)
        {
            try
            {
                return Ok(await _apiBusiness.GetScheduleAsync(studentId, accessToken));
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }
    }
}
