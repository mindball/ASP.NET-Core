#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3dc6f826aed36ef429f40ff935b26dccf08bb81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operations_Index), @"mvc.1.0.view", @"/Views/Operations/Index.cshtml")]
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
#line 1 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\_ViewImports.cshtml"
using ApplicationsServicesConfiguration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\_ViewImports.cshtml"
using ApplicationsServicesConfiguration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dc6f826aed36ef429f40ff935b26dccf08bb81", @"/Views/Operations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0127ab21717746a288f1367376a06a2671d7ac5", @"/Views/_ViewImports.cshtml")]
    public class Views_Operations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>Controller Operations: </p>\r\n<p>Transiant: ");
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
         Write(ViewBag.Transient.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Scoped: ");
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
      Write(ViewBag.Scoped.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n<p>Singleton: ");
#nullable restore
#line 4 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
         Write(ViewBag.Singleton.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n<p>Instance: ");
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
        Write(ViewBag.SingletonInstance.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n\r\n<p>OperationService Operations: </p>\r\n<p>Transiant: ");
#nullable restore
#line 8 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
         Write(ViewBag.Service.TransientOperation.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n<p>Scoped: ");
#nullable restore
#line 9 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
      Write(ViewBag.Service.ScopedOperation.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n<p>Singleton: ");
#nullable restore
#line 10 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
         Write(ViewBag.Service.SingletonOperation.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n<p>Instance: ");
#nullable restore
#line 11 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\ApplicationFlowFiltersMiddleware\ApplicationsServicesConfiguration\Views\Operations\Index.cshtml"
        Write(ViewBag.Service.SingletonInstanceOperation.OperationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>  \r\n");
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
