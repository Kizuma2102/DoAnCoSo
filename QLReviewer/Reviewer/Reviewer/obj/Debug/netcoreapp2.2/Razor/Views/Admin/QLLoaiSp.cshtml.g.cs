#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1f62495ed7a9e9ef0a6d009c3e396eafd2becc7a8800a58f775b53219910b2f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QLLoaiSp), @"mvc.1.0.view", @"/Views/Admin/QLLoaiSp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/QLLoaiSp.cshtml", typeof(AspNetCore.Views_Admin_QLLoaiSp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1f62495ed7a9e9ef0a6d009c3e396eafd2becc7a8800a58f775b53219910b2f1", @"/Views/Admin/QLLoaiSp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QLLoaiSp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reviewer.Models.Data.LoaiSp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
  
    ViewData["Title"] = "QLLoaiSp";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(145, 64, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center;color:black;\">Quản Lý Loại</h2>\r\n");
            EndContext();
            BeginContext(210, 66, false);
#line 8 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Partials/ThemLoai.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(276, 219, true);
            WriteLiteral("\r\n<table id=\"table_id\" class=\"display\">\r\n    <thead>\r\n        <tr>\r\n            <th>Mã Loại</th>\r\n            <th>Tên Loại</th>\r\n            <th>Mã Mục</th>\r\n            <th>Chức Năng</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 18 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(536, 55, true);
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(592, 41, false);
#line 22 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(633, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(661, 42, false);
#line 23 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenLoai));

#line default
#line hidden
            EndContext();
            BeginContext(703, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(731, 40, false);
#line 24 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaMuc));

#line default
#line hidden
            EndContext();
            BeginContext(771, 181, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary\" style=\"float:left; margin-right:10px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 952, "\"", 1016, 1);
#line 29 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
WriteAttributeValue("", 959, Url.Action("SuaLoai", "Admin", new { id = item.MaLoai }), 959, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1017, 147, true);
            WriteLiteral(">Sửa</a>\r\n                        </div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary\" style=\" float:left\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1164, "\"", 1229, 2);
#line 32 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
WriteAttributeValue("", 1171, Url.Action("XoaLoai", "Admin", new { id = item.MaLoai }), 1171, 57, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1228, "", 1229, 1, true);
            EndWriteAttribute();
            BeginContext(1230, 130, true);
            WriteLiteral(">Xóa</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n");
            EndContext();
#line 38 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLLoaiSp.cshtml"
    }

#line default
#line hidden
            BeginContext(1367, 353, true);
            WriteLiteral(@"

</table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reviewer.Models.Data.LoaiSp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
