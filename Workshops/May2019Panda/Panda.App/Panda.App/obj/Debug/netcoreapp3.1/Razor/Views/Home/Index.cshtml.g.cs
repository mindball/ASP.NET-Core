#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2acbf3261e6bf39f969effbb69f8084e0006e9f9"
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
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2acbf3261e6bf39f969effbb69f8084e0006e9f9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ddda226cc8df3cae0f6afcd062a209b5a8cd44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
 if(TempData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-success\">");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
                        Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 8 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron mt-3 bg-panda"">
        <h1 class=""text-white"">Welcome to PANDA Delivery Services.</h1>
        <hr class=""bg-white hr-2"" />
        <h3 class=""text-white""><a href=""/Identity/Account/Login"">Login</a> if you have an account.</h3>
        <h3 class=""text-white""><a href=""/Identity/Account/Register"">Register</a> if you don't.</h3>
    </div>
");
#nullable restore
#line 18 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center\">Hello, ");
#nullable restore
#line 21 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
                              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h1>
    <hr class=""hr-2 bg-panda"">
    <div class=""d-flex justify-content-between"">
        <div class=""w-25 bg-white"">
            <h2 class=""text-center"">Pending</h2>
            <div class=""border-panda p-3"">
                <div class=""p-2 d-flex justify-content-around"">
                    <h4 class=""w-75"">IPhone XS Case</h4>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1004, "\"", 1011, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\r\n                </div>\r\n                <div class=\"p-2 d-flex justify-content-around\">\r\n                    <h4 class=\"w-75\">TV table</h4>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1226, "\"", 1233, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\r\n                </div>\r\n                <div class=\"p-2 d-flex justify-content-around\">\r\n                    <h4 class=\"w-75\">Chushkopek</h4>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1450, "\"", 1457, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Details</a>\r\n                </div>\r\n                <div class=\"p-2 d-flex justify-content-around\">\r\n                    <h4 class=\"w-75\">Office Chair</h4>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1676, "\"", 1683, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn bg-panda text-white w-25"">Details</a>
                </div>
            </div>
        </div>
        <div class=""w-25 bg-white"">
            <h2 class=""text-center"">Shipped</h2>
            <div class=""border-panda p-3"">
                <div class=""p-2 d-flex justify-content-around"">
                    <h4 class=""w-75"">1959 Irish Bourbon</h4>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2075, "\"", 2082, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn bg-panda text-white w-25"">Details</a>
                </div>
            </div>
        </div>
        <div class=""w-25 bg-white"">
            <h2 class=""text-center"">Delivered</h2>
            <div class=""border-panda p-3"">
                <div class=""p-2 d-flex justify-content-around"">
                    <h4 class=""w-75"">Dog Toy</h4>
                    <a");
            BeginWriteAttribute("href", " href=\"", 2465, "\"", 2472, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Acquire</a>\r\n                </div>\r\n                <div class=\"p-2 d-flex justify-content-around\">\r\n                    <h4 class=\"w-75\">Mineral Water</h4>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2692, "\"", 2699, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn bg-panda text-white w-25\">Acquire</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591