using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas.Demo.Areas.Test.Controllers
{
    public class AreaTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
