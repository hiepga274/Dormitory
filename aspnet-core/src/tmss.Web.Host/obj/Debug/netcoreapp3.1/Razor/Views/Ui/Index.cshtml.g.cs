#pragma checksum "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1b189ae61c340e18fd0c67969f4dac003b2dc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ui_Index), @"mvc.1.0.view", @"/Views/Ui/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
using Abp.Web.Security.AntiForgery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
using tmss.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
using tmss.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1b189ae61c340e18fd0c67969f4dac003b2dc8", @"/Views/Ui/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1370a16bdeab798317ae25330c000ada8896ecc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Ui_Index : tmss.Web.Views.tmssRazorPage<tmss.Web.Models.Ui.HomePageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Ui/Index.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
  
    AbpAntiForgeryManager.SetCookie(Context, cookieOptions: new CookieOptions()
    {
        SameSite = SameSiteMode.Strict,
        Secure = true
    });

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1b189ae61c340e18fd0c67969f4dac003b2dc85042", async() => {
                WriteLiteral("\r\n    <title>tmss</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a1b189ae61c340e18fd0c67969f4dac003b2dc85335", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 17 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n<div class=\"main-content\">\r\n    <div class=\"user-name\"> ");
#nullable restore
#line 20 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
                       Write(Html.Raw(Model.GetShownLoginName()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>\r\n        <ul class=\"content-list\">\r\n");
#nullable restore
#line 23 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
             if (WebConsts.SwaggerUiEnabled)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 757, "\"", 792, 1);
#nullable restore
#line 25 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
WriteAttributeValue("", 764, WebConsts.SwaggerUiEndPoint, 764, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Swagger UI</a></li>\r\n");
#nullable restore
#line 26 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
             if (WebConsts.HangfireDashboardEnabled && IsGranted(AppPermissions.Pages_Administration_HangfireDashboard))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1032, 1);
#nullable restore
#line 29 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
WriteAttributeValue("", 996, WebConsts.HangfireDashboardEndPoint, 996, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Hangfire</a></li>\r\n");
#nullable restore
#line 30 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
             if (WebConsts.GraphQL.Enabled && WebConsts.GraphQL.PlaygroundEnabled)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1189, "\"", 1233, 1);
#nullable restore
#line 33 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
WriteAttributeValue("", 1196, WebConsts.GraphQL.PlaygroundEndPoint, 1196, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">GraphQL Playground</a></li>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"logout\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1342, "\"", 1403, 1);
#nullable restore
#line 38 "C:\Users\Admin\Downloads\Learn\CSDLNC\Dormitory\aspnet-core\src\tmss.Web.Host\Views\Ui\Index.cshtml"
WriteAttributeValue("", 1349, Url.Action("Logout", "Ui", new {area = string.Empty}), 1349, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\"Logout\"</a>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAbpAntiForgeryManager AbpAntiForgeryManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tmss.Web.Models.Ui.HomePageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
