using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Demo.Controllers
{
    public class TokenController : Controller
    {
        //https://localhost:5001/token - accessed        
        //[Route("")] //if also in HomeController is set, exception occurred
        [Route("Token")]
        //[Route("[controller]/[action]")]
        public IActionResult TokenIndex()
        {
            return this.Content("Token Index");
        }

        [Route("[controller]/[action]")] //accessed https://localhost:5001/token/tokenabout
        public IActionResult TokenAbout()
        {
            return this.Content("Token about");
        }
    }
}
