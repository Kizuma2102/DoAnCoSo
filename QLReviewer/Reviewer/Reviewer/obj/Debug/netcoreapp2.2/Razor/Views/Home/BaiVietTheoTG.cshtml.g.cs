#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41a5dc5eead7dce21fcc20dc3fab492033f262832fa7368fe29d2bef1e17e360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BaiVietTheoTG), @"mvc.1.0.view", @"/Views/Home/BaiVietTheoTG.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/BaiVietTheoTG.cshtml", typeof(AspNetCore.Views_Home_BaiVietTheoTG))]
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
#line 2 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
using X.PagedList;

#line default
#line hidden
#line 3 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
using X.PagedList.Mvc.Common;

#line default
#line hidden
#line 4 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"41a5dc5eead7dce21fcc20dc3fab492033f262832fa7368fe29d2bef1e17e360", @"/Views/Home/BaiVietTheoTG.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BaiVietTheoTG : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reviewer.ViewModel.BaiVietTheoLoai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
  
    ViewData["Title"] = "BaiVietTheoTG";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(242, 9, false);
#line 10 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
Write(ViewBag.a);

#line default
#line hidden
            EndContext();
            BeginContext(251, 169, true);
            WriteLiteral("\r\n<table id=\"table_id\" class=\"display custom-table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Mã Bài</th>\r\n            <th>Tên Bài</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 18 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(461, 55, true);
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(517, 40, false);
#line 22 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaBai));

#line default
#line hidden
            EndContext();
            BeginContext(557, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 586, "\"", 648, 1);
#line 23 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
WriteAttributeValue("", 593, Url.Action("Details", "Home", new { id = item.MaBai }), 593, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(649, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(651, 41, false);
#line 23 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
                                                                                 Write(Html.DisplayFor(modelItem => item.TenBai));

#line default
#line hidden
            EndContext();
            BeginContext(692, 48, true);
            WriteLiteral("</a></td>\r\n            </tr>\r\n        </tbody>\r\n");
            EndContext();
#line 26 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
    }

#line default
#line hidden
            BeginContext(747, 40, true);
            WriteLiteral("</table>\r\n<div class=\"pagination\">\r\n    ");
            EndContext();
            BeginContext(788, 96, false);
#line 29 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Home\BaiVietTheoTG.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("BaiVietTheoTG", new { page = page })));

#line default
#line hidden
            EndContext();
            BeginContext(884, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(894, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41a5dc5eead7dce21fcc20dc3fab492033f262832fa7368fe29d2bef1e17e3607299", async() => {
                BeginContext(916, 12, true);
                WriteLiteral("Back to Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(932, 1420, true);
            WriteLiteral(@"
<style>
    .custom-table {
        width: 100%;
        border-collapse: collapse;
    }

        .custom-table th,
        .custom-table td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        .custom-table th {
            background-color: #f2f2f2;
            font-weight: bold;
        }

        .custom-table tbody tr:hover {
            background-color: #f5f5f5;
        }

    .pagination {
        display: inline-block;
        padding: 0;
        margin: 20px 0;
    }

        .pagination a {
            color: #333;
            display: inline-block;
            padding: 8px 16px;
            text-decoration: none;
            border: 1px solid #ddd;
        }

            .pagination a.active {
                background-color: #4CAF50;
                color: white;
                border: 1px solid #4CAF50;
            }

            .pagination a:hover:not(.active) {
                b");
            WriteLiteral(@"ackground-color: #ddd;
            }
</style>

<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js""></script>
<script>
    $(document).ready(function () {
        $('#table_id').DataTable();
    });
</script>




");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reviewer.ViewModel.BaiVietTheoLoai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
