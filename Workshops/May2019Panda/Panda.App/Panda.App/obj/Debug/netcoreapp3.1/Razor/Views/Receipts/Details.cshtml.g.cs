#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eff3339156b7836bc44f574bdb697040be589ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receipts_Details), @"mvc.1.0.view", @"/Views/Receipts/Details.cshtml")]
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
using Panda.App.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models.Package;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.App.Models.Receipts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\_ViewImports.cshtml"
using Panda.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eff3339156b7836bc44f574bdb697040be589ba0", @"/Views/Receipts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93907f0cc3932b5a594522a8c7114dbae1a01b20", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReceiptDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
  
    ViewData["Title"] = "Receipt Details ";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">");
#nullable restore
#line 5 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<hr class=\"hr-2 bg-panda\">\r\n<div class=\"mx-auto\">\r\n    <div class=\"receipt-id-handler d-flex justify-content-between\">\r\n        <h3>Receipt Number:</h3>\r\n        <h3>");
#nullable restore
#line 10 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <hr class=\"hr-2 bg-panda\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <h4>Issued On:</h4>\r\n        <h4>");
#nullable restore
#line 15 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.IssuedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"d-flex justify-content-between\">\r\n        <h4>Delivery Address:</h4>\r\n        <h4>");
#nullable restore
#line 19 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.DeliveryAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <hr class=\"hr-2 bg-panda\">\r\n    <div class=\"d-flex justify-content-between\">\r\n        <h4>Package Weight (KG):</h4>\r\n        <h4>");
#nullable restore
#line 24 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"d-flex justify-content-between\">\r\n        <h4>Package Description:</h4>\r\n        <h4>");
#nullable restore
#line 28 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"d-flex justify-content-between\">\r\n        <h4>Recipient:</h4>\r\n        <h4>");
#nullable restore
#line 32 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
       Write(Model.RecipientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <hr class=\"hr-2 bg-panda\">\r\n    <div class=\"fee-holder d-flex justify-content-end\">\r\n        <h3>Total: $");
#nullable restore
#line 36 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Receipts\Details.cshtml"
               Write(Model.Fee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReceiptDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
