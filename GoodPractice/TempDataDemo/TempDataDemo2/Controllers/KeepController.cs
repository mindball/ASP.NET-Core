using Microsoft.AspNetCore.Mvc;

namespace TempDataDemo2.Controllers
{
    public class KeepController : Controller
    {
        public ActionResult Index()
        {
            TempData["name"] = "Bill";

            TempData.Keep("name"); // Marks the specified key in the TempData for retention.

            //TempData.Keep(); // Marks all keys in the TempData for retention

            return View();
        }

        public ActionResult Privacy()
        {
            string name;

            if (TempData.ContainsKey("name"))
            {
                TempData.Keep("name"); //transfer to next action
                name = TempData["name"] as string;
            }            

            return View();
        }

        public ActionResult Contact()
        {
            string name;

            if (TempData.ContainsKey("name"))
            {
                var data = TempData["name"] as string;
            }

            return View();
        }
    }
}
