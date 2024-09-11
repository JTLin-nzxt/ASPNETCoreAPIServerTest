using Microsoft.AspNetCore.Mvc;

namespace WebAPIExample.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceTestController : ControllerBase
    {
        private readonly ILogger<ServiceTestController> _logger;

        public ServiceTestController(ILogger<ServiceTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "ServiceTest Triggered";
        }
    }
}
