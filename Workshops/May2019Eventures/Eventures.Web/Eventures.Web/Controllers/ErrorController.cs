namespace Eventures.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using Eventures.Web.Models;
    using Microsoft.AspNetCore.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
        
    public class ErrorController : Controller
    {
        private ErrorViewModel errorModel;

        public ErrorController()
        {
            this.errorModel = new ErrorViewModel();
        }

        public IActionResult Error(int statusCode = 0)
        {
            // Switch to the appropriate page
            switch (statusCode)
            {
                case 404:
                    this.FillModel("404");
                    return this.View("PageNotFound", this.errorModel);                    
                case 500:
                    return this.View("AppError");
                default:
                    return this.View("AnytingError");
            };
            
        }

        private void FillModel(string code)
        {
            this.errorModel.RequestId = Activity.Current?.Id 
                ?? HttpContext.TraceIdentifier;
            this.errorModel.ErrorStatusCode = code;

            var statusCodeReExecuteFeature = HttpContext.Features.Get<
                                                   IStatusCodeReExecuteFeature>();

            if (statusCodeReExecuteFeature != null)
            {
                this.errorModel.OriginalURL =
                    statusCodeReExecuteFeature.OriginalPathBase
                    + statusCodeReExecuteFeature.OriginalPath
                    + statusCodeReExecuteFeature.OriginalQueryString;
            }
        }
    }
}
