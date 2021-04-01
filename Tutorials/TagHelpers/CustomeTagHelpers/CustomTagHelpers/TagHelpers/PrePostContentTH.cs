using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelpers.TagHelpers
{
    [HtmlTargetElement("td", Attributes = "underline")]
    public class PrePostContentTH : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.PreContent.SetHtmlContent("<u>");
            output.PostContent.SetHtmlContent("</u>");
        }
    }
}
