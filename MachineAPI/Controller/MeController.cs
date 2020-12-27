using MachineAPI.Config;
using System.Web.Http;

namespace MachineAPI.Controller
{
    [Route("api")]
    public class MeController : ApiController
    {
        [Route("me")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            Logger.Save();

            return Ok(new { message = "OK! Api host is running!" });
        }
    }
}