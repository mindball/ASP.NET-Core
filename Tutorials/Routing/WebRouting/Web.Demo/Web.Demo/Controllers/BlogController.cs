using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Demo.Controllers
{
    public class BlogController : Controller
    {
        //Default route loaded https://localhost:5001/blog & https://localhost:5001/article
        public IActionResult Article()
        {
            return this.Content("Default article");
        }

        public IActionResult OtherArticle()
        {
            return this.Content("Other Article");
        }
    }
}
