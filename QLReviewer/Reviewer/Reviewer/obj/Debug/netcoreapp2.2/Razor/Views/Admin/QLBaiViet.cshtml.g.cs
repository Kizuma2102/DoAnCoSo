#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00269d42463847b0a0f59604a12913f1fe1e93a4917bd30666e5f39e1edcdbf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QLBaiViet), @"mvc.1.0.view", @"/Views/Admin/QLBaiViet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/QLBaiViet.cshtml", typeof(AspNetCore.Views_Admin_QLBaiViet))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"00269d42463847b0a0f59604a12913f1fe1e93a4917bd30666e5f39e1edcdbf5", @"/Views/Admin/QLBaiViet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QLBaiViet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reviewer.Models.Data.BaiViet>>
    {
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
#line 2 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
  
    ViewData["Title"] = "QLBaiViet";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(147, 78, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center;color:black\">Quản Lý Bài Viết</h2>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(226, 62, false);
#line 9 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Partials/Them.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(288, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(2451, 420, true);
            WriteLiteral(@"


<table id=""myTable"" class=""table align-middle mb-0 bg-white tb1"">
    <thead class=""bg-light"">
        <tr class=""header-row"">
            <th>Tên Bài</th>
            <th>Tag</th>
            <th>Hình Ảnh Bài Viết</th>
            <th>Reviewer</th>
            <th>Lượt Xem</th>
            <th>Ngày Viết</th>
            <th>Tình Trạng</th>
            <th>Chức năng</th>
        </tr>
    </thead>
");
            EndContext();
#line 81 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(2914, 67, true);
            WriteLiteral("        <tbody class=\"tb2\">\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(2982, 41, false);
#line 86 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenBai));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3051, 40, false);
#line 87 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaTag));

#line default
#line hidden
            EndContext();
            BeginContext(3091, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3140, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00269d42463847b0a0f59604a12913f1fe1e93a4917bd30666e5f39e1edcdbf55802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3150, "~/Img/SmartPhone/", 3150, 17, true);
#line 89 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
AddHtmlAttributeValue("", 3167, item.HinhAnhBv, 3167, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3186, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(3232, 45, false);
#line 91 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaReviewer));

#line default
#line hidden
            EndContext();
            BeginContext(3277, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3305, 42, false);
#line 92 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
               Write(Html.DisplayFor(modelItem => item.LuotXem));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(3377, 43, false);
#line 94 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayViet));

#line default
#line hidden
            EndContext();
            BeginContext(3420, 31, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n");
            EndContext();
#line 97 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
                     if (item.TinhTrang == false)
                    {

#line default
#line hidden
            BeginContext(3525, 138, true);
            WriteLiteral("                        <p class=\"badge badge-success rounded-pill d-inline notAtv\" style=\"background-color: #FF6969;\">Hủy Kích Hoạt</p>\r\n");
            EndContext();
#line 100 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3735, 131, true);
            WriteLiteral("                        <p class=\"badge badge-success rounded-pill d-inline Atv\" style=\"background-color: #16FF00;\">Kích Hoạt</p>\r\n");
            EndContext();
#line 104 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
                    }

#line default
#line hidden
            BeginContext(3889, 207, true);
            WriteLiteral("                </td>\r\n                <td class=\"tb3\">\r\n                    <div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary\" style=\"float:left; margin-right:10px\"");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                href=\"", 4096, "\"", 4186, 1);
#line 110 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
WriteAttributeValue("", 4136, Url.Action("Sua","Admin", new { id = item.MaBai}), 4136, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4187, 264, true);
            WriteLiteral(@">Sửa</a>
                        </div>
                        <div>
                            <a class=""btn btn-primary btn-thu2"" style=""float:left; margin-right:10px""
                                onclick=""return confirm('Bạn có muốn hủy kích hoạt ?');""");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                href=\"", 4451, "\"", 4553, 1);
#line 115 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
WriteAttributeValue("", 4491, Url.Action("HuyKichHoatBV", "Admin", new { id = item.MaBai }), 4491, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4554, 132, true);
            WriteLiteral(">Xóa</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n\r\n            </tr>\r\n        </tbody>\r\n");
            EndContext();
#line 122 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLBaiViet.cshtml"
    }

#line default
#line hidden
            BeginContext(4693, 1241, true);
            WriteLiteral(@"</table>











<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"">
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js""></script>
<script>
    $(document).ready(function () {
        $('#table_id').DataTable();
    });
</script>
<script>
    $(document).ready(function () {
        $('#myTable').DataTable({
            ""language"": {
                ""sProcessing"": ""Đang xử lý..."",
                ""sLengthMenu"": ""Xem _MENU_ Bài Viết"",
                ""sZeroRecords"": ""Không tìm thấy Bài Viết nào phù hợp"",
                ""sInfo"": ""Đang xem _START_ đến _END_ trong tổng số _TOTAL_ "",
                ""sInfoEmpty"": ""Đang xem 0 đến 0 trong tổng số 0 Bài Viết"",
                ""sInfoFiltered"": ""(được lọc từ _MAX_ Bài Viết)"",
                ""sInfoPostFix"": """",
                ""sSearch"": ""Tìm Bài Viết:"",
                ""sUrl"": """",
                ""oPaginate"": {
        ");
            WriteLiteral("            \"sFirst\": \"Đầu\",\r\n                    \"sPrevious\": \"Trước\",\r\n                    \"sNext\": \"Tiếp\",\r\n                    \"sLast\": \"Cuối\"\r\n                }\r\n\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reviewer.Models.Data.BaiViet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
