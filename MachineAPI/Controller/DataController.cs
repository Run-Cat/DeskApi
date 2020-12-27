using MachineAPI.Config;
using System.Web.Http;

namespace MachineAPI.Controller
{
    [Route("api/service")]
    public class DataController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Get()
        {
            Logger.Save();

            return Ok(new { message = "OK! Api host is running!" });
        }
    }
}