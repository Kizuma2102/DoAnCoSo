#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9b24b8f52e02e3a2b762d1b58a50cbe8d089f6540461fac379a343ecb8f6b7f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QLChuyenMuc), @"mvc.1.0.view", @"/Views/Admin/QLChuyenMuc.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/QLChuyenMuc.cshtml", typeof(AspNetCore.Views_Admin_QLChuyenMuc))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9b24b8f52e02e3a2b762d1b58a50cbe8d089f6540461fac379a343ecb8f6b7f8", @"/Views/Admin/QLChuyenMuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QLChuyenMuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reviewer.Models.Data.ChuyenMuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
  
    ViewData["Title"] = "QLChuyenMuc";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(151, 70, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center;color:black;\">Quản Lý Chuyên Mục</h2>\r\n");
            EndContext();
            BeginContext(222, 65, false);
#line 8 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Partials/ThemMuc.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(287, 225, true);
            WriteLiteral("\r\n<table id=\"table_id\" class=\"display\">\r\n    <thead>\r\n        <tr>\r\n            <th>Mã Mục</th>\r\n            <th>Tên Mục</th>\r\n            <th>CSS Chuyên Mục</th>\r\n            <th>Chức Năng</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 18 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(553, 55, true);
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(609, 40, false);
#line 22 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaMuc));

#line default
#line hidden
            EndContext();
            BeginContext(649, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(677, 41, false);
#line 23 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenMuc));

#line default
#line hidden
            EndContext();
            BeginContext(718, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(746, 48, false);
#line 24 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
               Write(Html.DisplayFor(modelItem => item.HinhChuyenMuc));

#line default
#line hidden
            EndContext();
            BeginContext(794, 181, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary\" style=\"float:left; margin-right:10px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 975, "\"", 1037, 1);
#line 29 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
WriteAttributeValue("", 982, Url.Action("SuaMuc", "Admin", new { id = item.MaMuc }), 982, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1038, 156, true);
            WriteLiteral(">Sửa</a>\r\n                        </div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary btn-thu2\" style=\" float:left\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1257, 2);
#line 32 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
WriteAttributeValue("", 1201, Url.Action("XoaMuc", "Admin", new { id = item.MaMuc }), 1201, 55, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1256, "", 1257, 1, true);
            EndWriteAttribute();
            BeginContext(1258, 130, true);
            WriteLiteral(">Xóa</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n");
            EndContext();
#line 38 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLChuyenMuc.cshtml"
    }

#line default
#line hidden
            BeginContext(1395, 353, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reviewer.Models.Data.ChuyenMuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
