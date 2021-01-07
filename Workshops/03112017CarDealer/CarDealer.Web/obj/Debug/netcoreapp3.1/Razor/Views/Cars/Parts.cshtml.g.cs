#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f8ea5f2604d250b3d0b33b3a147a9f7b2fb736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Parts), @"mvc.1.0.view", @"/Views/Cars/Parts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f8ea5f2604d250b3d0b33b3a147a9f7b2fb736", @"/Views/Cars/Parts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316390565caccc26f328f85d7f0e33d017694072", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Parts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarWithParts>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
  
    ViewData["Title"] = "Cars with parts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

<div class=""container"">
    <ul class=""pagination"">
        <li><a href=""#"">1</a></li>
        <li class=""active""><a href=""#"">2</a></li>
        <li><a href=""#"">3</a></li>
        <li><a href=""#"">4</a></li>
        <li><a href=""#"">5</a></li>
    </ul>
</div>

<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Make</th>
            <th>Model</th>
            <th>Travelled Distance</th>
            <th>Parts</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
          
            foreach (var car in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                   Write(car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                   Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                   Write(car.TravelledDistance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <ul>\r\n");
#nullable restore
#line 38 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                             foreach (var part in car.Parts)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 40 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                                Write($"{part.Name} - {part.Price}$");

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarWithParts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
