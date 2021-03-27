using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Demo.Controllers
{
    /* Both of the controller's actions, PostJson and PostForm, 
     * handle POST requests with the same URL. 
     * Without the [Consumes] attribute applying a type constraint, 
     * an ambiguous match exception is thrown.
     * */
    public class ConsumesController : BaseController
    {
        //send body array with [1, 2, 3, 4]
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostJson(IEnumerable<int> values) => //handles requests sent with a Content-Type header of application/json.
            Ok(new { Consumes = "application/json", Values = values });

        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult PostForm([FromForm] IEnumerable<int> values) => //handles requests sent with a Content-Type header application/x-www-form-urlencoded.
            Ok(new { Consumes = "application/x-www-form-urlencoded", Values = values });
    }
}

