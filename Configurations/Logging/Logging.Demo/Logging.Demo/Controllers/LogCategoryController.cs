using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logging.Demo.Controllers
{
    public class LogCategoryController : Controller
    {
        const string categoryName = "explicitlyCategory";

        private readonly ILogger<LogCategoryController> _logger;
        //Explicitly specify the category
        private readonly ILogger createCategory;

        public LogCategoryController(ILogger<LogCategoryController> logger,
            ILoggerFactory createCategory)
        {
            _logger = logger;
            this.createCategory = createCategory.CreateLogger(categoryName);

        }

        public IActionResult Index()
        {
            //Execute on: VS output console and Kestrel console
            this._logger.LogInformation($"{nameof(LogCategoryController)}/{nameof(Index)}  called.");
            return this.Content(nameof(LogCategoryController));
        }

        //Explicitly specify the category
        public IActionResult Category()
        {
            this._logger.LogInformation(categoryName);
            return this.Content($"Explicitly specify the category {categoryName}");
        }
    }
}
