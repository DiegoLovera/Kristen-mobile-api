using kristen_mobile_api.Business.Exceptions;
using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kristen_mobile_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KristenController : KristenBaseController
    {
        private readonly IKristenBusiness _apiBusiness;
        public KristenController(IKristenBusiness apiBusiness)
        {
            _apiBusiness = apiBusiness;
        }

        [HttpGet("/News")]
        public async Task<ActionResult<NewsDetail>> GetNews([FromQuery]string career, [FromQuery]string skip)
        {
            try
            {
                var response = await _apiBusiness.GetNewsAsync(career, skip);
                return Ok(response);
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/News/{id}")]
        public async Task<ActionResult<NewsDetail>> GetNewsDetail(string id)
        {
            try
            {
                return Ok(await _apiBusiness.GetNewsDetailAsync(id));
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/Notices")]
        public async Task<ActionResult<IEnumerable<Notice>>> GetNotices()
        {
            try
            {
                return Ok(await _apiBusiness.GetNoticesAsync());
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/Calendar")]
        public async Task<ActionResult<string>> GetCalendar()
        {
            try
            {
                return Ok(await _apiBusiness.GetCalendarUrlAsync());
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }

        [HttpGet("/Contacts")]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            try
            {
                return Ok(await _apiBusiness.GetContactsAsync());
            }
            catch (ApiRequestException ex)
            {
                return (ErrorCodeCheck(ex.ErrorCode));
            }
        }
    }
}
