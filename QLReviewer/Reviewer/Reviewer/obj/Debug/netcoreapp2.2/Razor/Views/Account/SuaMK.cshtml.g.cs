#pragma checksum "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "44b18fc4182df713ad137f8bc78c8ba9c52dd6b5be707da512d63162099df552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuaMK), @"mvc.1.0.view", @"/Views/Account/SuaMK.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SuaMK.cshtml", typeof(AspNetCore.Views_Account_SuaMK))]
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
#line 1 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"44b18fc4182df713ad137f8bc78c8ba9c52dd6b5be707da512d63162099df552", @"/Views/Account/SuaMK.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"34e0797b7e25bc8a8a98eb8cde719d7c10274115e96151479c8e7f3a119c2b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SuaMK : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reviewer.Models.Data.Author>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/additional-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
  
    ViewData["Title"] = "Đổi Mật Khẩu";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
            BeginContext(169, 297, true);
            WriteLiteral(@"
<script src=""https://code.jquery.com/jquery.min.js""></script>
<style>
    label.error {
        color: red;
    }
</style>
<div class=""panel panel-default"">
    <div class=""panel-heading"" style=""margin-top:30px;text-align:center"">ĐỔI MẬT KHẨU</div>
    <div class=""panel-body"">
        ");
            EndContext();
            BeginContext(466, 3058, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b18fc4182df713ad137f8bc78c8ba9c52dd6b5be707da512d63162099df5526490", async() => {
                BeginContext(551, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
             using (Html.BeginForm("SuaMK", "Account", FormMethod.Post, new { @enctype = "multipart/form-data" }))
            {
                

#line default
#line hidden
                BeginContext(701, 23, false);
#line 20 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(743, 64, false);
#line 21 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(826, 41, false);
#line 22 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
           Write(Html.HiddenFor(model => model.MaReviewer));

#line default
#line hidden
                EndContext();
                BeginContext(869, 207, true);
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label class=\"control-label col-sm-3\" for=\"username\">Tên đăng nhập:</label>\r\n                    <div class=\"col-sm-9\">\r\n                        ");
                EndContext();
                BeginContext(1077, 122, false);
#line 26 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
                   Write(Html.EditorFor(model => model.UsernameRe, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1199, 393, true);
                WriteLiteral(@"
                        <p id=""messageUser""></p>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-3"" for=""pass"">Mật khẩu cũ:</label>
                    <div class=""col-sm-9"">
                        <input name=""Password"" class=""form-control"" placeholder=""Mật khẩu cũ"" type=""password"" />");
                EndContext();
                BeginContext(1593, 19, false);
#line 33 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
                                                                                                           Write(ViewBag.ThongBaoLoi);

#line default
#line hidden
                EndContext();
                BeginContext(1612, 962, true);
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-3"" for=""pass"">Mật khẩu mới:</label>
                    <div class=""col-sm-9"">
                        <input name=""PasswordRe"" class=""form-control"" placeholder=""Mật khẩu mới"" type=""password"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-3"" for=""pass"">Nhập lại mật khẩu mới:</label>
                    <div class=""col-sm-9"">
                        <input name=""Nhaplai"" class=""form-control"" placeholder=""Nhập lại"" type=""password"" />
                    </div>
                </div>
                <div hidden=""hidden"" class=""form-group"">
                    <label class=""control-label col-sm-3"" for=""pass"">Họ tên:</label>
                    <div class=""col-sm-9"">
                        ");
                EndContext();
                BeginContext(2575, 99, false);
#line 51 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
                   Write(Html.EditorFor(model => model.FullnameRe, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2674, 265, true);
                WriteLiteral(@"
                    </div>
                </div>
                <div hidden=""hidden"" class=""form-group"">
                    <label class=""control-label col-sm-3"" for=""pass"">Email:</label>
                    <div class=""col-sm-9"">
                        ");
                EndContext();
                BeginContext(2940, 96, false);
#line 57 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
                   Write(Html.EditorFor(model => model.EmailRe, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3036, 458, true);
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""control-label col-sm-3""></label>
                    <div class=""col-sm-9"">
                        <button type=""reset"" class=""btn btn-default btnDelete"">Xóa</button>
                        <button type=""submit"" class=""btn btn-primary btnRegister"">Đổi mật khẩu</button>
                    </div>
                </div>
");
                EndContext();
#line 67 "D:\DACS\Đồ Án Cơ Sở - Final\QLReviewer\Reviewer\Reviewer\Views\Account\SuaMK.cshtml"
            }

#line default
#line hidden
                BeginContext(3509, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3524, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3565, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3571, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b18fc4182df713ad137f8bc78c8ba9c52dd6b5be707da512d63162099df55214283", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3642, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3648, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44b18fc4182df713ad137f8bc78c8ba9c52dd6b5be707da512d63162099df55215563", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3722, 397, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#form1"").validate({
                rules: {
                    PasswordRe: { required: true },
                    Nhaplai: { equalTo: ""input[name='PasswordRe']"" },
                },
                messages: {
                    Nhaplai: { equalTo: ""Không khớp"" },
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4122, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reviewer.Models.Data.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
