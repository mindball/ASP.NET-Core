using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Demo.Controllers
{
    public class MultipleParametersController : Controller
    {
        //multiple parameters passed to an action
        public IActionResult Parameters(int level, string type, int id)
        {
            ParametersVM model = new ParametersVM()
            {
                Level = level,
                Type = type,
                ID = id
            };

            return View(model);
        }
    }

    public class ParametersVM
    {
        public int Level { get; set; }

        public string Type { get; set; }

        public int ID { get; set; }
    }
}
