#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\IndexDanhMuc\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25bd6b4d8dccb368f6b86531236684ce03e52fb30c991e2ce0a0c8a4e3ee89e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_IndexDanhMuc_Default), @"mvc.1.0.view", @"/Views/Shared/Components/IndexDanhMuc/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/IndexDanhMuc/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_IndexDanhMuc_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"25bd6b4d8dccb368f6b86531236684ce03e52fb30c991e2ce0a0c8a4e3ee89e3", @"/Views/Shared/Components/IndexDanhMuc/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_IndexDanhMuc_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\IndexDanhMuc\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(155, 103, true);
            WriteLiteral("<div class=\"header_fasion\">\r\n    <div class=\"left_fashion main_nav_box\">\r\n        <ul>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 258, "\"", 285, 1);
#line 9 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\IndexDanhMuc\Default.cshtml"
WriteAttributeValue("", 266, item.HinhChuyenMuc, 266, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(286, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 289, "\"", 296, 0);
            EndWriteAttribute();
            BeginContext(297, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(299, 11, false);
#line 9 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\IndexDanhMuc\Default.cshtml"
                                                  Write(item.TenMuc);

#line default
#line hidden
            EndContext();
            BeginContext(310, 102, true);
            WriteLiteral("</a></li>\r\n        </ul>\r\n    </div>\r\n    <div class=\"fasion_right\">\r\n        <ul>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 412, "\"", 419, 0);
            EndWriteAttribute();
            BeginContext(420, 38, true);
            WriteLiteral(">Mới nhất</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 458, "\"", 465, 0);
            EndWriteAttribute();
            BeginContext(466, 32, true);
            WriteLiteral(">Cũ</a></li>\r\n            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 498, "\"", 505, 0);
            EndWriteAttribute();
            BeginContext(506, 54, true);
            WriteLiteral(">Tất cả</a></li>\r\n            <li class=\"last_item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 560, "\"", 567, 0);
            EndWriteAttribute();
            BeginContext(568, 129, true);
            WriteLiteral(">...</a></li>\r\n        </ul>\r\n    </div>\r\n    </div>\r\n    <div class=\"gadgets_area_box\">\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(698, 55, false);
#line 23 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\IndexDanhMuc\Default.cshtml"
       Write(await Component.InvokeAsync("BaiVietIndex", item.MaMuc));

#line default
#line hidden
            EndContext();
            BeginContext(753, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 26 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Shared\Components\IndexDanhMuc\Default.cshtml"
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