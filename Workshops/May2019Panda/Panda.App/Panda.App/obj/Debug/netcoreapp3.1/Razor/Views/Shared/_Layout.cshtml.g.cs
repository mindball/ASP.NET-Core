#pragma checksum "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "677f6f21bd88db16655da96b915c11feb1a74381"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"677f6f21bd88db16655da96b915c11feb1a74381", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93907f0cc3932b5a594522a8c7114dbae1a01b20", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-href", "~/lib/bootstrap/dist/css/bootstrap.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-class", "sr-only", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-property", "position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-value", "absolute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString("sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/reset-css.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<div class=\"container-fluid\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438111054", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\" />\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n        <title>");
#nullable restore
#line 7 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Panda.App</title>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438111770", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677f6f21bd88db16655da96b915c11feb1a7438112056", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438114282", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677f6f21bd88db16655da96b915c11feb1a7438114568", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackHref = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestClass = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestProperty = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestValue = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677f6f21bd88db16655da96b915c11feb1a7438117962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677f6f21bd88db16655da96b915c11feb1a7438119146", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "677f6f21bd88db16655da96b915c11feb1a7438120330", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438122222", async() => {
                WriteLiteral("\r\n        <header>\r\n");
#nullable restore
#line 25 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
             if (!this.User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <nav class=""navbar navbar-expand-lg navbar-dark bg-panda"">
                    <a class=""navbar-brand nav-link-white"" href=""/"">PANDA</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse d-flex justify-content-between"" id=""navbarNav"">
                        <ul class=""navbar-nav"">
                        </ul>
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/Packages/Index"">Home</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/Identity/Account/");
                WriteLiteral(@"Login"">Login</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/Identity/Account/Register"">Register</a>
                            </li>
                        </ul>
                    </div>
                </nav>
");
#nullable restore
#line 48 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
            }
            else if (this.User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <nav class=""navbar navbar-expand-lg navbar-dark bg-panda"">
                    <a class=""navbar-brand nav-link-white"" href=""/"">PANDA</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <a class=""navbar-brand nav-link-white"" href=""/Packages/Pending"">Pending</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <a class=""navbar-brand nav-link-white"" href=""/Packages/ShippedAll"">Shipped</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" ");
                WriteLiteral(@"data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <a class=""navbar-brand nav-link-white"" href=""/Packages/DeliveredAll"">Delivered</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <a class=""navbar-brand nav-link-white"" href=""/Packages/Create"">Create</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""colla");
                WriteLiteral(@"pse navbar-collapse d-flex justify-content-between"" id=""navbarNav"">
                        <ul class=""navbar-nav"">
                        </ul>
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/"">Home</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/Receipts/Index/"">Receipts</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/Identity/Account/Logout"">Logout</a>
                            </li>
                        </ul>
                    </div>
                </nav>
");
#nullable restore
#line 88 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <nav class=""navbar navbar-expand-lg navbar-dark bg-panda"">
                    <a class=""navbar-brand nav-link-white"" href=""/"">PANDA</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>                                 
                    <div class=""collapse navbar-collapse d-flex justify-content-between"" id=""navbarNav"">                        
                        <ul class=""navbar-nav"">
                        </ul>
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/"">Home</a>
                            </li>         
                            <li class=""nav-item"">
                                <a class=""nav-");
                WriteLiteral(@"link nav-link-white active"" href=""/Receipts/Index/"">Receipts</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link nav-link-white active"" href=""/Identity/Account/Logout"">Logout</a>
                            </li>
                        </ul>
                    </div>
                </nav>
");
#nullable restore
#line 112 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </header>\r\n        <main class=\"mt-3\">\r\n            ");
#nullable restore
#line 115 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
        <footer>
            <div class=""container-fluid bg-panda"">
                <div class=""text-white p-2 text-center"">
                    &copy; CopyRight Sanity Web Design Studios 2018. All rights reserved.
                </div>
            </div>
        </footer>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438130407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438131512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "677f6f21bd88db16655da96b915c11feb1a7438132617", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
#nullable restore
#line 126 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 128 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("Notyf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 129 "C:\Users\oilaripi\source\repos\ASP.NET Core\ASP.NET-Core\Workshops\May2019Panda\Panda.App\Panda.App\Views\Shared\_Layout.cshtml"
   Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n</html>\r\n");
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
