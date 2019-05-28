using kristen_mobile_api.Business.Interfaces;
using kristen_mobile_api.Clients.Interfaces;
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

        // GET api/values/5
        [HttpGet("/News/{id}")]
        public async Task<ActionResult<string>> Get(string id)
        {
            return await apiBusiness.GetNewsContentsAsync(id);
        }
    }
}
