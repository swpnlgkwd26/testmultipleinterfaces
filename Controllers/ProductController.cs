using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMultipleInterfaces.Models;

namespace TestMultipleInterfaces.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICustomInterface customInterface;
        private readonly ICustomInterface _serviceResolver;
        public ProductController(ServiceResolver serviceResolver)
        {
            _serviceResolver = serviceResolver("C");
        }

        public IActionResult Index()
        {
            ViewBag.Data = _serviceResolver.GetData();
            return View();
        }
    }
}
