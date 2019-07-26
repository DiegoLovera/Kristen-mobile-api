using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace kristen_mobile_api.Controllers
{
    public abstract class KristenBaseController : ControllerBase
    {
        protected StatusCodeResult ErrorCodeCheck(HttpStatusCode code)
        {
            switch (code)
            {
                case HttpStatusCode.BadRequest:
                    return BadRequest();
                case HttpStatusCode.InternalServerError:
                    return StatusCode(StatusCodes.Status500InternalServerError);
                case HttpStatusCode.NotFound:
                    return NotFound();
                case HttpStatusCode.NotImplemented:
                    return StatusCode(StatusCodes.Status501NotImplemented);
                case HttpStatusCode.RequestTimeout:
                    return StatusCode(StatusCodes.Status408RequestTimeout);
                default:
                    return StatusCode((int)code);
            }
        }
    }
}
