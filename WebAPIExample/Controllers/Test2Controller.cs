using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        private readonly ILogger<Test2Controller> _logger;

        public Test2Controller(ILogger<Test2Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
    }
}
