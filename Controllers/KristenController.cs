using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Clients.Interfaces;
using kristen_mobile_api.Data.Models;
using kristen_mobile_data.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kristen_mobile_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KristenController : ControllerBase
    {
        private readonly IKristenBusiness _apiBusiness;
        public KristenController(IKristenBusiness apiBusiness)
        {
            _apiBusiness = apiBusiness;
        }

        [HttpGet("/News/{career}")]
        public async Task<ActionResult<NewsDetail>> GetNews(string career, [FromQuery] int skip)
        {
            return Ok(await _apiBusiness.GetNewsAsync(career, skip));
        }

        [HttpGet("/News/Content/{id}")]
        public async Task<ActionResult<NewsDetail>> GetNewsDetail(string id)
        {
            return Ok(await _apiBusiness.GetNewsDetailAsync(id));
        }

        [HttpGet("/Notices")]
        public async Task<ActionResult<IEnumerable<Notice>>> GetNotices()
        {
            return Ok(await _apiBusiness.GetNoticesAsync());
        }

        [HttpGet("/Calendar")]
        public async Task<ActionResult<string>> GetCalendar()
        {
            return Ok(await _apiBusiness.GetCalendarUrlAsync());
        }

        [HttpGet("/Contacts")]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return Ok(await _apiBusiness.GetContactsAsync());
        }
    }
}
