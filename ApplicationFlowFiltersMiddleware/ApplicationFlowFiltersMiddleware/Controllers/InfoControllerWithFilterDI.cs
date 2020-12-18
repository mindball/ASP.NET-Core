using ApplicationFlowFiltersMiddleware.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationFlowFiltersMiddleware.Controllers
{

    [TypeFilter(typeof(FilterDependencyInjectionTypeFilter))] 
    public class InfoControllerWithFilterDI : Controller
    {
        //Filter must register in Dependency container
        [ServiceFilter(typeof(FilterDependencyInjectionServiceFilter))] 
        public IActionResult Time()
        {
            return this.Content(DateTime.Now.ToLongTimeString());
        }

        [TypeFilter(typeof(FilterDependencyInjectionTypeFilter))]
        public IActionResult Date()
        {
            return this.Content(DateTime.Now.ToLongDateString());
        }
    }
}
