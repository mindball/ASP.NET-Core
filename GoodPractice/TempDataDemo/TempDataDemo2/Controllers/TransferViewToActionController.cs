using Microsoft.AspNetCore.Mvc;

namespace TempDataDemo2.Controllers
{
    public class TransferViewToActionController : Controller
    {
        public IActionResult Index()
        {
            if (TempData.ContainsKey("name"))
            {
                string name = TempData["name"].ToString(); 
            }

            return View();
        }

        public IActionResult Privacy()
        {
            if (TempData.ContainsKey("name"))
            {
                string name = TempData["name"].ToString();  
            }                

            return View();
        }

        public ActionResult Contact()
        {
            if (TempData.ContainsKey("name"))
            {
                string name = TempData["name"].ToString(); 
            }

            return View();
        }
    }
}
