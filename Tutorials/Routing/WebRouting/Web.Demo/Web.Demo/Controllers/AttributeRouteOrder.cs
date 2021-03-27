using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Demo.Controllers
{
    public class AttributeRouteOrder : Controller
    {
        [Route("")]        
        [Route("Home", Order = 2)]
        [Route("Home/MyIndex")]
        public IActionResult Index(int? id)
        {
            return this.Content(nameof(Index));
        }       
    }
}
