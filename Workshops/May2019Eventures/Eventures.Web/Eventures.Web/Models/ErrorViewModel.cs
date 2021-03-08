using System;

namespace Eventures.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);

        public string ErrorStatusCode { get; set; }

        public string OriginalURL { get; set; }

        public bool ShowOriginalURL => !string.IsNullOrEmpty(this.OriginalURL);
    }
}
