using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Demo.Controllers
{

    public class TokenController : BaseController
    {
        //https://localhost:5001/token - accessed        
        //[Route("")] //if also in HomeController is set, exception occurred
        [Route("Token")]
        //[Route("[controller]/[action]")]
        public ActionResult<string> TokenIndex()
        {
            return this.Content("Token Index");
        }

        //[Route("[controller]/[action]")] //accessed https://localhost:5001/token/tokenabout
        public ActionResult<string> TokenAbout()
        {
            return this.Content("Token about");
        }
    }
}
