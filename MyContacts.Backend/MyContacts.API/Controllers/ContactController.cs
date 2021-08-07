using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyContacts.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "API online" });
        }
    }
}
