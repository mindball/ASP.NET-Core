#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\CustomerSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7deee3cdb31c14b44f51cccc5bb9f72fa387fdcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerSales), @"mvc.1.0.view", @"/Views/Customers/CustomerSales.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7deee3cdb31c14b44f51cccc5bb9f72fa387fdcf", @"/Views/Customers/CustomerSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316390565caccc26f328f85d7f0e33d017694072", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerSales>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\CustomerSales.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\CustomerSales.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sales</h2>\r\n\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 163, "\"", 171, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>            \r\n            <th>Name</th>\r\n            <th>Bought Car Count</th>\r\n            <th>Spend Money</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\CustomerSales.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\CustomerSales.cshtml"
               Write(Model.BoughtCarCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Customers\CustomerSales.cshtml"
               Write(Model.SpendMoney);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \r\n            </tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerSales> Html { get; private set; }
    }
}
#pragma warning restore 1591
