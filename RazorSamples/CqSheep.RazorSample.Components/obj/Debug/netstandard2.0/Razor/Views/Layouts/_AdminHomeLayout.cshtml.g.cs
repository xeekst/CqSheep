#pragma checksum "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d62990c0bcafa85c2ba9dbc814bdeada1a4d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layouts__AdminHomeLayout), @"mvc.1.0.view", @"/Views/Layouts/_AdminHomeLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Layouts/_AdminHomeLayout.cshtml", typeof(AspNetCore.Views_Layouts__AdminHomeLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d62990c0bcafa85c2ba9dbc814bdeada1a4d07", @"/Views/Layouts/_AdminHomeLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Layouts__AdminHomeLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/flex.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 49, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html style=\"font-size:unset\">\r\n");
            EndContext();
            BeginContext(49, 1763, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d62990c0bcafa85c2ba9dbc814bdeada1a4d074390", async() => {
                BeginContext(55, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(177, 17, false);
#line 6 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(194, 43, true);
                WriteLiteral(" - CqSheep.RazorSample.Host</title>\r\n\r\n    ");
                EndContext();
                BeginContext(237, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81d62990c0bcafa85c2ba9dbc814bdeada1a4d075312", async() => {
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
                BeginContext(284, 1521, true);
                WriteLiteral(@"
    <script src=""https://cdn.bootcss.com/jquery/3.4.1/jquery.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
    <link href=""https://cdn.bootcss.com/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.css"" rel=""stylesheet"">
    <!-- <link href=""https://cdn.bootcss.com/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker-standalone.min.css"" rel=""stylesheet""> -->
    <script src=""https://cdn.bootcss.com/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
    <script src=""https://cdn.bootcss.com/echarts/4.2.1-rc1/echarts.min.js""></script>
    <style>
        .header-positio");
                WriteLiteral(@"n {
            position: sticky;
            width: 100%;
            top: 0;
            background-color: #fff;
            z-index:1000;
        }
        .content-position{
            background-color: #ebecee;
            width: 100%;
            z-index:20;
        }
        .footer-position{
            width: 100%;
            height: 3.75rem;
            border-top: 1px solid #e1e5eb!important;
            background-color: #fff!important;
        }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(1812, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1814, 940, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d62990c0bcafa85c2ba9dbc814bdeada1a4d079027", async() => {
                BeginContext(1837, 111, true);
                WriteLiteral("\r\n    <div class=\"flex-row flex-main-start flex-align-start\">\r\n        <div style=\"width:16.7%;\">\r\n            ");
                EndContext();
                BeginContext(1949, 74, false);
#line 40 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
       Write(await Html.PartialAsync("~/Views/Partials/Admin/AdminMenusPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2023, 166, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"flex-column flex-main-start flex-align-center\" style=\"width:83.3%\">\r\n            <div class=\"header-position\">\r\n                ");
                EndContext();
                BeginContext(2190, 75, false);
#line 44 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Partials/Admin/AdminHeaderPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2265, 82, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"content-position\">\r\n                ");
                EndContext();
                BeginContext(2348, 67, false);
#line 47 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/ComponentItems/Navigation.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2415, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2434, 12, false);
#line 48 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2446, 81, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"footer-position\">\r\n                ");
                EndContext();
                BeginContext(2528, 75, false);
#line 51 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Partials/Admin/AdminFooterPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(2603, 56, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(2660, 41, false);
#line 56 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2701, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2708, 37, false);
#line 57 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
Write(RenderSection("Css", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2745, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2754, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
