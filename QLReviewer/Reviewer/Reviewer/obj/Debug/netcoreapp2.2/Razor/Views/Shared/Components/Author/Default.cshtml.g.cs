#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Author\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "72c29bcf9a9a5dddc3c8ec99a50267a3b093125182e402ec3ea18061f8a6136b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Author_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Author/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Author/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Author_Default))]
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
#line 1 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer;

#line default
#line hidden
#line 2 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\_ViewImports.cshtml"
using Reviewer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"72c29bcf9a9a5dddc3c8ec99a50267a3b093125182e402ec3ea18061f8a6136b", @"/Views/Shared/Components/Author/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Author_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/tacgia.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(128, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72c29bcf9a9a5dddc3c8ec99a50267a3b093125182e402ec3ea18061f8a6136b4546", async() => {
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
            EndContext();
            BeginContext(175, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Author\Default.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
            BeginContext(352, 95, true);
            WriteLiteral("    <li>\r\n        <div class=\"tacgia\">\r\n            <div class=\"tacgia--ava\">\r\n                ");
            EndContext();
            BeginContext(447, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72c29bcf9a9a5dddc3c8ec99a50267a3b093125182e402ec3ea18061f8a6136b6216", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 457, "~/Img/Reviewer/", 457, 15, true);
#line 16 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Author\Default.cshtml"
AddHtmlAttributeValue("", 472, item.AvatarRe, 472, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(495, 79, true);
            WriteLiteral("\r\n            </div>\r\n            <h4 class=\"tacgia--name\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 574, "\"", 643, 1);
#line 19 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Author\Default.cshtml"
WriteAttributeValue("", 581, Url.Action("BaiVietTheoTG","Home", new { id=item.MaReviewer}), 581, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(644, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(668, 15, false);
#line 20 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Author\Default.cshtml"
               Write(item.FullnameRe);

#line default
#line hidden
            EndContext();
            BeginContext(683, 74, true);
            WriteLiteral("\r\n                </a>\r\n            </h4>\r\n        </div>\r\n\r\n\r\n    </li>\r\n");
            EndContext();
#line 27 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\Author\Default.cshtml"
}

#line default
#line hidden
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
