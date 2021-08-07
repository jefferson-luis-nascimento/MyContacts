using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MyContacts.API.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IServiceProvider ServiceProvider;

        protected T GetService<T>() => ServiceProvider.GetService<T>();

        public BaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}
