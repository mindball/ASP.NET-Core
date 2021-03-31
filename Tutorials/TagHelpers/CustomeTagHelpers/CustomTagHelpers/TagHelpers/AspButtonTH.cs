using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpers.TagHelpers
{
    [HtmlTargetElement("aspbutton")]
    public class AspButtonTH : TagHelper
    {
        
        public string Type { get; set; } = "Submit";
        
        public string Title { get; set; } = "Custom Tag Helpers";

        public string BackgroundColor { get; set; } = "primary";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", $"btn btn-{BackgroundColor}");
            output.Attributes.SetAttribute("type", Type);           
            output.Attributes.SetAttribute("title", Title);           
            output.Content.SetContent("Click to Add Record");
        }
    }
}
