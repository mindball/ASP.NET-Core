using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TempDataDemo2.Controllers
{
    public class TransferActionToActionController : Controller
    {
        public IActionResult Index()
        {
            //transfer data from one action method to another and reqding by view
            TempData["name"] = "Bill";

            return View();
        }

        public IActionResult Privacy()
        {
            string name;

            //transfer data from one action method to another and reqding by view
            if (TempData.ContainsKey("name"))
                name = TempData["name"].ToString(); // returns "Bill" 

            return View();
        }

        public ActionResult Contact()
        {
            //the following throws exception as TempData["name"] is null 
            //because we already accessed it in the About() action method
            //name = TempData["name"].ToString(); 

            string name;
            //transfer data from one action method to another
            if (TempData.ContainsKey("name"))
                name = TempData["name"].ToString(); // returns "Bill" 

            return View();
        }
    }
}
