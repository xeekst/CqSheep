#pragma checksum "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3201e5c0fd9655361e1c8e83425584461fe82907"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3201e5c0fd9655361e1c8e83425584461fe82907", @"/Views/Layouts/_AdminHomeLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Layouts__AdminHomeLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/flex.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3201e5c0fd9655361e1c8e83425584461fe829074030", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 43, true);
                WriteLiteral(" - CqSheep.RazorSample.Host</title>\r\n\r\n    ");
                EndContext();
                BeginContext(213, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3201e5c0fd9655361e1c8e83425584461fe829074967", async() => {
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
                BeginContext(260, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(269, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(271, 693, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3201e5c0fd9655361e1c8e83425584461fe829077095", async() => {
                BeginContext(277, 90, true);
                WriteLiteral("\r\n    <div class=\"flex-row flex-main-start flex-align-start\">\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(368, 74, false);
#line 13 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
       Write(await Html.PartialAsync("~/Views/Partials/Admin/AdminMenusPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(442, 122, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"flex-column flex-main-start flex-align-center\">\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(565, 75, false);
#line 17 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Partials/Admin/AdminHeaderPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(640, 39, true);
                WriteLiteral("\r\n            </div>\r\n            <div>");
                EndContext();
                BeginContext(680, 12, false);
#line 19 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
            Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(692, 43, true);
                WriteLiteral("</div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(736, 75, false);
#line 21 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
           Write(await Html.PartialAsync("~/Views/Partials/Admin/AdminFooterPartial.cshtml"));

#line default
#line hidden
                EndContext();
                BeginContext(811, 60, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n    ");
                EndContext();
                BeginContext(872, 41, false);
#line 26 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(913, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(920, 35, false);
#line 27 "C:\Users\xeekseven\source\repos\RazorSamples\CqSheep.RazorSample.Components\Views\Layouts\_AdminHomeLayout.cshtml"
Write(RenderSection("Css",required:false));

#line default
#line hidden
                EndContext();
                BeginContext(955, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(964, 11, true);
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