namespace CreateAndUseInMemoryDB.Filters.ActionFilters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;
    using System.Diagnostics;
    using System.IO;

    public class LogFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var controllerInfo = context.Controller.GetType().Name;
            var dateTimeNow = DateTime.UtcNow.ToString();
            var action = context.RouteData.Values["action"];
            var getIp = context.HttpContext.Connection.RemoteIpAddress;
            var user = context.HttpContext.User?.Identity?.Name ?? "Anonymous";

            var logMsg = $"{dateTimeNow} – {getIp} – {user} – {controllerInfo}.{ action}";

            if(context.Exception != null)
            {
                var exceptionType = context.Exception.GetType().Name;
                var exceptionMsg = context.Exception.Message;

                logMsg = $"[!] {logMsg} – {exceptionType} – {exceptionMsg}";
            }

            using (var streamWriter = new StreamWriter("logMsg.txt", true))
            {
                streamWriter.WriteLine(logMsg);
            }
        }
    }
}
