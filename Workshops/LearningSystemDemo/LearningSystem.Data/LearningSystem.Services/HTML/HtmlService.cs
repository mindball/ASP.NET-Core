using Ganss.XSS;
using System;

namespace LearningSystem.Services.HTML
{
    public class HtmlService : IHtmlService
    {
        private readonly HtmlSanitizer htmlSanitizer;
        public HtmlService()
        {
            this.htmlSanitizer = new HtmlSanitizer();
            htmlSanitizer.AllowedAttributes.Add("class");
        }
        public string Sanitize(string htmlContent)
            => this.htmlSanitizer.Sanitize(htmlContent);
        
    }
}
