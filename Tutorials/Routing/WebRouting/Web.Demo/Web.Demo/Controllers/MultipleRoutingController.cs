using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Demo.Controllers
{
    public class MultipleRoutingController : Controller
    {
        //[Route("")]
        //[Route("/")]
        public IActionResult Index()
        {
            return this.Content("MultipleRouting");
        }
    }
}
