using ApplicationFlowFiltersMiddleware.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Controllers
{

    [AddHeaderActionActionFilterAttributeClassFilter] //Ще се изпълни на всички преди и след всеки action-и
    public class InfoControllerWithActionFilterAttribute : Controller
    {
        public IActionResult Time()
        {
            return this.Content(DateTime.Now.ToLongTimeString());
        }

        public IActionResult Date()
        {
            return this.Content(DateTime.Now.ToLongDateString());
        }
    }
}
