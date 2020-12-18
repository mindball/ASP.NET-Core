using ApplicationFlowFiltersMiddleware.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Controllers
{

    
    public class InfoControllerSpecificFilterAttribute : Controller
    {
        [AddHeaderActionAttributeFilter]
        public IActionResult Time()
        {
            return this.Content(DateTime.Now.ToLongTimeString());
        }

        //[AddHeaderActionActionFilterAttributeClassFilter]
        public IActionResult Date()
        {
            return this.Content(DateTime.Now.ToLongDateString());
        }
    }
}
