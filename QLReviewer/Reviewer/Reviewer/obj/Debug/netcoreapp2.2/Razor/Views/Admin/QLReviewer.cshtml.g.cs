#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "df2fbecb74add3105ca1bdb183d40029c4f74606a2a6a08970b07ad5ce8e60aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_QLReviewer), @"mvc.1.0.view", @"/Views/Admin/QLReviewer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/QLReviewer.cshtml", typeof(AspNetCore.Views_Admin_QLReviewer))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"df2fbecb74add3105ca1bdb183d40029c4f74606a2a6a08970b07ad5ce8e60aa", @"/Views/Admin/QLReviewer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_QLReviewer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reviewer.Models.Data.Author>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
  
    ViewData["Title"] = "QLReviewer";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(147, 67, true);
            WriteLiteral("\r\n<h2 style=\"text-align:center;color:black;\">Quản Lý Tác Giả</h2>\r\n");
            EndContext();
            BeginContext(215, 63, false);
#line 8 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Partials/Them1.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(278, 339, true);
            WriteLiteral(@"
<table id=""table_id"" class=""display"">
    <thead>
        <tr>
            <th>Họ Tên</th>
            <th>Tài Khoản</th>
            <th>Mật Khẩu</th>
            <th>Email</th>
            <th>Avartar</th>
            <th>Địa Chỉ</th>
            <th>Số tiền</th>
            <th>Chức Năng</th>
        </tr>
    </thead>
");
            EndContext();
#line 22 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(658, 55, true);
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(714, 45, false);
#line 26 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
               Write(Html.DisplayFor(modelItem => item.FullnameRe));

#line default
#line hidden
            EndContext();
            BeginContext(759, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(787, 45, false);
#line 27 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
               Write(Html.DisplayFor(modelItem => item.UsernameRe));

#line default
#line hidden
            EndContext();
            BeginContext(832, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(860, 45, false);
#line 28 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
               Write(Html.DisplayFor(modelItem => item.PasswordRe));

#line default
#line hidden
            EndContext();
            BeginContext(905, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(933, 42, false);
#line 29 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
               Write(Html.DisplayFor(modelItem => item.EmailRe));

#line default
#line hidden
            EndContext();
            BeginContext(975, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1024, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df2fbecb74add3105ca1bdb183d40029c4f74606a2a6a08970b07ad5ce8e60aa7070", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1034, "~/Img/Reviewer/", 1034, 15, true);
#line 31 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
AddHtmlAttributeValue("", 1049, item.AvatarRe, 1049, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(1090, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1136, 43, false);
#line 33 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiaChiRe));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1207, 41, false);
#line 34 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoTien));

#line default
#line hidden
            EndContext();
            BeginContext(1248, 181, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary\" style=\"float:left; margin-right:10px\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1429, "\"", 1494, 1);
#line 39 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
WriteAttributeValue("", 1436, Url.Action("Sua1", "Admin", new { id = item.MaReviewer }), 1436, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1495, 156, true);
            WriteLiteral(">Sửa</a>\r\n                        </div>\r\n                        <div>\r\n                            <a class=\"btn btn-primary btn-thu2\" style=\" float:left\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1651, "\"", 1717, 2);
#line 42 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
WriteAttributeValue("", 1658, Url.Action("Xoa1", "Admin", new { id = item.MaReviewer }), 1658, 58, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1716, "", 1717, 1, true);
            EndWriteAttribute();
            BeginContext(1718, 130, true);
            WriteLiteral(">Xóa</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n");
            EndContext();
#line 48 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Admin\QLReviewer.cshtml"
    }

#line default
#line hidden
            BeginContext(1855, 351, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reviewer.Models.Data.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
