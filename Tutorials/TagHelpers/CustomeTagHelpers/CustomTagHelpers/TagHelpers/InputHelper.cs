using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IO;

namespace CustomTagHelpers.TagHelpers
{
    [HtmlTargetElement("input-helper")]
    public class InputHelper : TagHelper
    {
        private readonly IHtmlGenerator generator;

        public InputHelper(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }        

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            using (var writer = new StringWriter())
            {
                writer.Write(@"<div class=""form-group"">");

                var label = generator.GenerateLabel(
                                ViewContext,
                                For.ModelExplorer,
                                For.Name, null,
                                new { @class = "control-label" });

                label.WriteTo(writer, NullHtmlEncoder.Default);

                var textArea = generator.GenerateTextBox(ViewContext,
                                    For.ModelExplorer,
                                    For.Name,
                                    For.Model,
                                    null,
                                    new { @class = "form-control" });

                textArea.WriteTo(writer, NullHtmlEncoder.Default);

                var validationMsg = generator.GenerateValidationMessage(
                                        ViewContext,
                                        For.ModelExplorer,
                                        For.Name,
                                        null,
                                        ViewContext.ValidationMessageElement,
                                        new { @class = "text-danger" });

                validationMsg.WriteTo(writer, NullHtmlEncoder.Default);

                writer.Write(@"</div>");

                output.Content.SetHtmlContent(writer.ToString());
            }
        }
    }
}
