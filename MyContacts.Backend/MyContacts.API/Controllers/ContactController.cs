using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Interface.Services;
using System;
using System.Threading.Tasks;

namespace MyContacts.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        //private readonly INaturalPersonService _naturalPersonGetAllService;

        private readonly IRepository<NaturalPerson> _naturalPersonGetAllService;

        public ContactController(IRepository<NaturalPerson> naturalPersonGetAllService)
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
