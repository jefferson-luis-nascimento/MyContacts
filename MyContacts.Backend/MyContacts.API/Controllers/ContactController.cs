using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyContacts.Interface.Services;
using System;
using System.Threading.Tasks;

namespace MyContacts.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private readonly INaturalPersonGetAllService _naturalPersonGetAllService;

        public ContactController(INaturalPersonGetAllService naturalPersonGetAllService)
        {
            _naturalPersonGetAllService = naturalPersonGetAllService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _naturalPersonGetAllService.GetAll());
        }
    }
}
