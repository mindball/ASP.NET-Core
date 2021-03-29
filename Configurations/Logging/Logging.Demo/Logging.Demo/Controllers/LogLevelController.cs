using Logging.Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging.Demo.Controllers
{
    public class LogLevelController : Controller
    {
        private readonly ILogger<LogLevelController> _logger;  

        public LogLevelController(ILogger<LogLevelController> logger)
        {
            this._logger = logger;           
        }

        public IActionResult Index(int id)
        {
            var routeInfo = ControllerContext.ToCtxString(id);

            this._logger.Log(LogLevel.Information, MyLogEvents.TestItem, routeInfo);
            this._logger.LogInformation(MyLogEvents.TestItem, routeInfo);

            StringBuilder str = new StringBuilder();
            str.AppendLine("Set Loglevel LogLevel.Information");
            str.AppendLine("call _logger.LogInformation");
            str.AppendLine("info: Logging.Demo.Controllers.LogLevelController[3000]");
            str.AppendLine("    /loglevel/index/1  id = 1   LogLevel.Index");

            return ControllerContext.MyDisplayRouteInfo(id, str.ToString());
        }

        //The following code creates Information and Warning logs:
        public IActionResult GetTodoItem(long id)
        {
            _logger.LogInformation(MyLogEvents.GetItem, "Getting item {Id}", id);

            var items = new List<Item> {
                new Item { Id = 0, Name = "TV"},
                //new Item { Id = 1, Name = "PC"},
                new Item { Id = 2, Name = "Heater"}
            };

            var todoItem = items.Where(a => a.Id == id).Select(a => a.Name).FirstOrDefault();

            if (todoItem == null)
            {
                _logger.LogWarning(MyLogEvents.GetItemNotFound, "Get({Id}) NOT FOUND", id);
                return NotFound();
            }

            return this.Content("Successfully add/remove/edit Item entity");
        }
    }

    //Each log can specify an event ID.The sample app uses the MyLogEvents class to define event IDs:
    internal class MyLogEvents
    {
        public const int GenerateItems = 1000;
        public const int ListItems = 1001;
        public const int GetItem = 1002;
        public const int InsertItem = 1003;
        public const int UpdateItem = 1004;
        public const int DeleteItem = 1005;

        public const int TestItem = 3000;

        public const int GetItemNotFound = 4000;
        public const int UpdateItemNotFound = 4001;
    }

    internal class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
