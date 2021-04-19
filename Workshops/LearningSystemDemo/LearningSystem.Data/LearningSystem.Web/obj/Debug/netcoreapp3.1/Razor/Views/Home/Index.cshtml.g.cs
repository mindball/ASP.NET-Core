#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db3b4176047f7162b98bc544e04ab0262a251d1e"
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
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Web.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Web.Models.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Services.Courses.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\_ViewImports.cshtml"
using LearningSystem.Services.Users.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3b4176047f7162b98bc544e04ab0262a251d1e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a3cd8e05a44d03138a18b0a20d789a729d0bb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Active courses";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"text-center\">Welcome to our learning system!</h1>\r\n</div>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
     foreach (var course in Model.Courses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--<div class=\"col-md-4\">\r\n            <div class=\"panel panel-default\">\r\n                <div class=\"panel-heading\">\r\n                    <h3 class=\"panel-title text-center\">");
#nullable restore
#line 16 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
                                                   Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"panel-body\">-->\r\n");
            WriteLiteral("        <!--</div>\r\n            </div>\r\n        </div>-->\r\n        <div class=\"col-md-3 text-center my-auto\">\r\n            <div class=\"card\" style=\"width: 20rem;\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1077, "\"", 1161, 2);
            WriteAttributeValue("", 1083, "http://thecatapi.com/api/images/get?format=src&type=gif&guid=", 1083, 61, true);
#nullable restore
#line 29 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1144, Guid.NewGuid(), 1144, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                    <br />\r\n                    <p class=\"text-center\">");
#nullable restore
#line 31 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
                                      Write(course.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 31 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
                                                                              Write(course.EndDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1357, "\"", 1391, 2);
            WriteAttributeValue("", 1364, "/courses/details/", 1364, 17, true);
#nullable restore
#line 32 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1381, course.Id, 1381, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Detail</a>                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\LearningSystemDemo\LearningSystem.Data\LearningSystem.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
