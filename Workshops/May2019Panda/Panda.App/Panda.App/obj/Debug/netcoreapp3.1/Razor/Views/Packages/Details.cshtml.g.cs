#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2282e0e9020e2d85aff8b90f7d9e16a18bf66472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_Details), @"mvc.1.0.view", @"/Views/Packages/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models.Package;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models.Receipts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2282e0e9020e2d85aff8b90f7d9e16a18bf66472", @"/Views/Packages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93907f0cc3932b5a594522a8c7114dbae1a01b20", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PackageDetailedBindingModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
  
    ViewData["Title"] = "Package Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
  
    var deliverDate = Model.EstimatedDeliveryDate == null ? "N/A" : Model.EstimatedDeliveryDate.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 11 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<hr class=""hr-2 bg-panda"">
<div class=""mx-auto"">
    <div class=""address-and-date-holder d-flex justify-content-around"">
        <div class=""d-flex flex-column"">
            <h2 class=""text-center"">Address</h2>
            <h3 class=""text-center mt-1"">");
#nullable restore
#line 17 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                                    Write(Model.ShippingAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"d-flex flex-column\">\r\n            <h2 class=\"text-center\">Status</h2>\r\n            <h3 class=\"text-center mt-1\">");
#nullable restore
#line 21 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                                    Write(Model.PackageStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"d-flex flex-column\">\r\n            <h2 class=\"text-center\">Estimated Delivery Date</h2>\r\n            <h3 class=\"text-center mt-1\">");
#nullable restore
#line 25 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                                    Write(deliverDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>
        </div>
    </div>
    <hr class=""hr-2 bg-panda"">
    <div class=""w-75 mx-auto weight-and-recipient-holder d-flex justify-content-between"">
        <div class=""d-flex flex-column w-50"">
            <h2 class=""text-center"">Weight</h2>
            <h3 class=""text-center mt-1"">");
#nullable restore
#line 32 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                                    Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div class=\"d-flex flex-column w-50\">\r\n            <h2 class=\"text-center\">Recipient</h2>\r\n            <h3 class=\"text-center mt-1\">");
#nullable restore
#line 36 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                                    Write(Model.Recipient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n    </div>\r\n    <hr class=\"hr-2 w-75 bg-panda\">\r\n    <div>\r\n        <h2 class=\"text-center\">Description</h2>\r\n        <h3 class=\"text-center mt-3\">");
#nullable restore
#line 42 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n\r\n    <div class=\"text-center\">\r\n        ");
#nullable restore
#line 46 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Packages\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2282e0e9020e2d85aff8b90f7d9e16a18bf664729204", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PackageDetailedBindingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
