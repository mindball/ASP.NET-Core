#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924ac2e976a755ef0fc2df34054eb177d01e7751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"924ac2e976a755ef0fc2df34054eb177d01e7751", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"316390565caccc26f328f85d7f0e33d017694072", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarPageListiningViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
  
    ViewData["Title"] = "All cars";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
      
    var previousDisable = Model.CurrentPage == 1 ? "disable" : string.Empty;
    var nextDisable = Model.NextPage == Model.TotalPages ? "disable" : string.Empty;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 12 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3><a class=\"btn btn-info\" href=\"/cars/create\" role=\"button\">Add car</a></h3>\r\n\r\n<ul class=\"pagination\">\r\n    <li");
            BeginWriteAttribute("class", " class=\"", 402, "\"", 436, 2);
            WriteAttributeValue("", 410, "page-item", 410, 9, true);
#nullable restore
#line 16 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue(" ", 419, previousDisable, 420, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 450, "\"", 484, 2);
            WriteAttributeValue("", 458, "page-link", 458, 9, true);
#nullable restore
#line 17 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue(" ", 467, previousDisable, 468, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 485, "\"", 529, 2);
            WriteAttributeValue("", 492, "/cars/index/?page=", 492, 18, true);
#nullable restore
#line 17 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue("", 510, Model.PreviousPage, 510, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n            <span aria-hidden=\"true\">&laquo;</span>\r\n            <span class=\"sr-only\">Previous</span>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 22 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
     for (int i = 1; i < Model.TotalPages; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 751, "\"", 820, 2);
            WriteAttributeValue("", 759, "page-item", 759, 9, true);
#nullable restore
#line 24 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue(" ", 768, Model.CurrentPage == i ? "active" : string.Empty, 769, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 842, "\"", 869, 2);
            WriteAttributeValue("", 849, "/cars/index/?page=", 849, 18, true);
#nullable restore
#line 24 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue("", 867, i, 867, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
                                                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 25 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 898, "\"", 928, 2);
            WriteAttributeValue("", 906, "page-item", 906, 9, true);
#nullable restore
#line 26 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue(" ", 915, nextDisable, 916, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 942, "\"", 972, 2);
            WriteAttributeValue("", 950, "page-link", 950, 9, true);
#nullable restore
#line 27 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue(" ", 959, nextDisable, 960, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1013, 2);
            WriteAttributeValue("", 980, "/cars/index/?page=", 980, 18, true);
#nullable restore
#line 27 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue("", 998, Model.NextPage, 998, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n            <span aria-hidden=\"true\">&raquo;</span>\r\n            <span class=\"sr-only\">Next</span>\r\n        </a>\r\n    </li>\r\n</ul>\r\n<table class=\"table table-bordered table-hover\">\r\n    <thead");
            BeginWriteAttribute("class", " class=\"", 1227, "\"", 1235, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Make</th>\r\n            <th>Model</th>\r\n            <th>Travelled Distance</th>           \r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
          
            int index = 1;
            foreach (var car in Model.Cars)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 49 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
                               Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1663, "\"", 1695, 2);
            WriteAttributeValue("", 1670, "/cars/bymake/", 1670, 13, true);
#nullable restore
#line 51 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
WriteAttributeValue("", 1683, car.CarMake, 1683, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
                                                       Write(car.CarMake);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
                   Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
                   Write(car.TravelledDistance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\03112017CarDealer\CarDealer.Web\Views\Cars\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarPageListiningViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
