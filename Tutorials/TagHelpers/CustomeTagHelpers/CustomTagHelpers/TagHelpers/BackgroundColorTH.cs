using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelpers.TagHelpers
{
    /*
     * The attribute – [HtmlTargetElement(Attributes = "background-color")] on the class tells that 
     * this Tag Helper applies to those html element that have the attribute background-color on them.
     */
    [HtmlTargetElement(Attributes = "background-color")]
    /*
     * You can also apply more than one [HtmlTargetElement()] attribute to the tag helper
     */
    [HtmlTargetElement("a", Attributes = "background-color")]
    public class BackgroundColorTH : TagHelper
    {
        public string BackgroundColor { get; set; }

        public string TooltipName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BackgroundColor}");
        }
    }
}
