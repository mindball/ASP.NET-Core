using Microsoft.AspNetCore.Mvc;
using WorkingWithData.ViewModels;

namespace WorkingWithData.Controllers
{
    //Kenov
    public class CatsController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(CatDetailsModel model)
        {
            
            if(ModelState.IsValid)
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            //ако валидациите не минат, страницата ще се refresh-не със същата form-а 
            //данните ще се запазят
            return View(model);
        }

        public IActionResult Create() => View();
    }
}
