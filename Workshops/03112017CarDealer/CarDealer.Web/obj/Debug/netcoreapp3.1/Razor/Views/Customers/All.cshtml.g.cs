#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0797625477e914b4aae4652706b57d62c934fc51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_All), @"mvc.1.0.view", @"/Views/Customers/All.cshtml")]
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
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Services.DTO.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Services.DTO.Car;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Services.DTO.Part;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Services.DTO.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Parts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Suppliers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0797625477e914b4aae4652706b57d62c934fc51", @"/Views/Customers/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316390565caccc26f328f85d7f0e33d017694072", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllCustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchCustomers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
  
    ViewData["Title"] = "All Customers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>All cutomers</h2>\r\n<h3>Order by Birth day and order by <strong>");
#nullable restore
#line 6 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
                                       Write(Model.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0797625477e914b4aae4652706b57d62c934fc516888", async() => {
                WriteLiteral("\r\n    <label for=\"SearchCustomer\">Search customer</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"search\" size=\"20\"");
                BeginWriteAttribute("value", " value=\"", 380, "\"", 388, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br>   \r\n    <input type=\"button\" class=\"btn btn-primary\" name=\"Search\" value=\"Submit\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 566, "\"", 574, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Name</th>\r\n            <th>Birthday</th>\r\n            <th>Young Driver</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
          
            int index = 1;
            foreach (var customer in Model.OrderCustomers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
                               Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
                   Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
                   Write(customer.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
                    Write(customer.IsYoungDriver ? "Yes" : "No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1218, "\"", 1266, 2);
            WriteAttributeValue("", 1225, "/customers/edit/", 1225, 16, true);
#nullable restore
#line 39 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
WriteAttributeValue("", 1241, customer.Id.ToString(), 1241, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Edit</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\All.cshtml"
                index++;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllCustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
