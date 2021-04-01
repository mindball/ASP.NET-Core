using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpers.Controllers
{
    public class CreateFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
