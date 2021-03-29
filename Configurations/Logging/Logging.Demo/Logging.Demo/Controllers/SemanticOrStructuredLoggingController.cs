using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logging.Demo.Controllers
{
    public class SemanticOrStructuredLoggingController : Controller
    {
        private readonly ILogger<SemanticOrStructuredLoggingController> _logger;

        public SemanticOrStructuredLoggingController(ILogger<SemanticOrStructuredLoggingController> logger)
        {
            this._logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                throw new Exception("Semantic Or Structured");

            }
            catch (Exception ex)
            {
                //Method LogError has two parameters(Exception, messages)
                //message: Time parameter is Semantic processed by {}
                /* Print:
                 *  fail: Logging.Demo.Controllers.SemanticOrStructuredLoggingController[0]
                          There are a bad exception at 03/29/2021 10:26:03
                 */
                this._logger.LogError(ex, "There are a bad exception at {Time}", DateTime.UtcNow);
            }

            return this.View();
        }
    }
}
