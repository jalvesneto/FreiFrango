using Microsoft.AspNetCore.Mvc;

namespace FreiFrango.WebApi.Controllers
{
    [ApiController]
    [Route("FreiFrango")]
    public class FreiFrangoController : ControllerBase
    {

        private readonly ILogger<FreiFrangoController> _logger;

        public FreiFrangoController(ILogger<FreiFrangoController> logger)
        {
            _logger = logger;
        }

        [Route("HealtCheck")]
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult("I am alive and working!");
        }
    }
}