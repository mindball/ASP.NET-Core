namespace MoiteRecepti2.Web.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;

    using System.Collections.Generic;

    public class TimeZoneControlViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string timeZoneId)
        {
            var timeZones = new List<string>();
            timeZones.AddRange(new[] { "GMT", "CET", "IST" });

            return this.View("Default", timeZones.ToArray());
        }
    }
}
