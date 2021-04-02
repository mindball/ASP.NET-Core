using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;

namespace LearningSystem.Web.TagHelpers
{
    [HtmlTargetElement("input-helper")]
    public class InputHelper : TagHelper
    {
        [HtmlAttributeName("asp-for")]
        public ModelExpression For { get; set; }

        private IHtmlGenerator generator;

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public InputHelper(IHtmlGenerator generator)
        {
            this.generator = generator;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            using (var writer = new StringWriter())
            {
                writer.Write(@"<div class=""form-group"">");

                var label = generator.GenerateLabel(
                                ViewContext,
                                For.ModelExplorer,
                                For.Name, null,
                                new { @class = "control-label" });

                label.WriteTo(writer, NullHtmlEncoder.Default);

                var textArea = generator.GenerateTextBox(
                                    ViewContext,
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
