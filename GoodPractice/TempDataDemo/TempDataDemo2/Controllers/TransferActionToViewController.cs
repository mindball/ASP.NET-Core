using Microsoft.AspNetCore.Mvc;

namespace TempDataDemo2.Controllers
{
    public class TransferActionToViewController : Controller
    {
        public IActionResult Index()
        {
            //transfer data from  action method to view
            TempData["name"] = "Bill";

            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }

        public ActionResult Contact()
        {           

            return View();
        }
    }
}
