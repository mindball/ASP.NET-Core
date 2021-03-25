using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Demo.Controllers
{
    public class ParameterTransformersController : Controller
    {
        //by default is accessed -> /user/namesandhealthdata
        //But that's not great for readability. What if we wanted instead to generate this URL:
        ///Parameter-Transformers/names-and-health-data
        ///if only ParameterController -> access it by Parameter/names-and-health-data
        [HttpGet("[controller]/[action]")]
        public IActionResult NamesAndHealthData()
        {
            return this.Content("Names-And-Health-Data");
        }
    }
}
