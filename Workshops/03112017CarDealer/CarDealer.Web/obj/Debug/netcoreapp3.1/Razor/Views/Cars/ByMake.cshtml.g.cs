#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049c8e1d9beb1bb301b2229981c1355f6c184e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_ByMake), @"mvc.1.0.view", @"/Views/Cars/ByMake.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049c8e1d9beb1bb301b2229981c1355f6c184e62", @"/Views/Cars/ByMake.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316390565caccc26f328f85d7f0e33d017694072", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_ByMake : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarsByMakeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
  
    ViewData["Title"] = "All Cars";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>All cars</h2>\r\n<h3><strong>");
#nullable restore
#line 8 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
       Write(Model.Maker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 197, "\"", 205, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Make</th>\r\n            <th>Model</th>\r\n            <th>Travelled distance</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
          
            int index = 1;
            foreach (var car in Model.CarsByMake)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
                               Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
                   Write(car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
                   Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
                   Write(car.TravelledDistance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 792, "\"", 830, 2);
            WriteAttributeValue("", 799, "/cars/edit/", 799, 11, true);
#nullable restore
#line 31 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
WriteAttributeValue("", 810, car.Id.ToString(), 810, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Edit</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\ByMake.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarsByMakeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591