#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94df1c31145809034f9d54ad839ec1d157f77a72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\_ViewImports.cshtml"
using ApproachWithDIMicrosoftVersion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\_ViewImports.cshtml"
using ApproachWithDIMicrosoftVersion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94df1c31145809034f9d54ad839ec1d157f77a72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b861d90d3ef86e14350c8f9c440cb14b47d54805", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApproachWithDIMicrosoftVersion.Data.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "List movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\InitializeSeedingDataApproach\ApproachWithDIMicrosoftVersion\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApproachWithDIMicrosoftVersion.Data.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
