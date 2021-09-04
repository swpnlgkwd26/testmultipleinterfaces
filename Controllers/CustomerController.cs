using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMultipleInterfaces.Models;

namespace TestMultipleInterfaces.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomInterface customInterface;
        private readonly ICustomInterface _serviceResolver;


        public CustomerController(ServiceResolver serviceResolver)
        {
            _serviceResolver = serviceResolver("A");
        }

        public IActionResult Index()
        {
            ViewBag.Data = _serviceResolver.GetData();

            return View();
        }
    }
}
