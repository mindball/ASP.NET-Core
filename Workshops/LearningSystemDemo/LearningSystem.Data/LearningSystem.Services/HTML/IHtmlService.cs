using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystem.Services.HTML
{
    public interface IHtmlService
    {
        string Sanitize(string htmlContent);
    }
}
