#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd839d516f55c6353840703d290690a9bac19c66"
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
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\_ViewImports.cshtml"
using TempDataDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\_ViewImports.cshtml"
using TempDataDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd839d516f55c6353840703d290690a9bac19c66", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1578832ecca97f73aa7b91df9686fd74fa2567fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TempDataDemo.Models.HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Flash Message Test";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
Write(Html.Partial("_FlashMessage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div>\r\n            ");
#nullable restore
#line 13 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
       Write(Html.LabelFor(x => x.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 17 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
       Write(Html.LabelFor(x => x.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            ");
#nullable restore
#line 19 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(x => x.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" value=\"Go!\" />\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\GoodPractice\TempDataDemo\TempDataDemo\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TempDataDemo.Models.HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
