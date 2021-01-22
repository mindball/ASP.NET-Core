using Microsoft.AspNetCore.Mvc;
using WorkingWithData.Models.ModelBinderExample;

namespace WorkingWithData.Controllers
{
    public class ModelBinderExampleController : Controller
    {

        public IActionResult CustomBinder([FromRoute]ModelBinderExampleInputViewModel input)
        {            
            return this.Json(input);
        }
    }
}
