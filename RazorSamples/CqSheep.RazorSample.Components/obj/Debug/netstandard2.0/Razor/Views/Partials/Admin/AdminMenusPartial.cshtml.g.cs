#pragma checksum "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0371254bb8eb6024fb70b43ff6355013f42bc0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Admin_AdminMenusPartial), @"mvc.1.0.view", @"/Views/Partials/Admin/AdminMenusPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/Admin/AdminMenusPartial.cshtml", typeof(AspNetCore.Views_Partials_Admin_AdminMenusPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0371254bb8eb6024fb70b43ff6355013f42bc0b", @"/Views/Partials/Admin/AdminMenusPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Admin_AdminMenusPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("main-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-table-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/shards-dashboards-logo-info.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Shards Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
   
    var type = ViewData["MenuType"];
    var menuType = MenuType.OverViews;
    if(type != null ){
        menuType = (MenuType)type;
    }

#line default
#line hidden
            BeginContext(153, 197, true);
            WriteLiteral("<div class=\"flex-column flex-main-start flex-align-center menu-contain\">\r\n    <div class=\"menu menu-title\">\r\n        <div class=\"flex-row flex-main-center flex-align-center mt-table\">\r\n            ");
            EndContext();
            BeginContext(350, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a0371254bb8eb6024fb70b43ff6355013f42bc0b5360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(487, 235, true);
            WriteLiteral("\r\n            <span class=\"mt-title\">Shards Dashboard</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"menu menu-selector\">\r\n        <ul class=\"flex-column flex-main-start flex-align-start nav\">\r\n            <li class=\"menu-item\">\r\n");
            EndContext();
#line 18 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
                 if (menuType == MenuType.OverViews)
                {

#line default
#line hidden
            BeginContext(795, 237, true);
            WriteLiteral("                    <a class=\"menu-link active\" href=\"/Admin/Overview\">\r\n                        <span class=\"glyphicon glyphicon-cog\" aria-hidden=\"true\"></span>\r\n                        <span>OverViews</span>\r\n                    </a>\r\n");
            EndContext();
#line 24 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1092, 230, true);
            WriteLiteral("                    <a class=\"menu-link\" href=\"/Admin/Overview\">\r\n                        <span class=\"glyphicon glyphicon-cog\" aria-hidden=\"true\"></span>\r\n                        <span>OverViews</span>\r\n                    </a>\r\n");
            EndContext();
#line 31 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1341, 57, true);
            WriteLiteral("\r\n            </li>\r\n            <li class=\"menu-item\">\r\n");
            EndContext();
#line 35 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
                 if (menuType == MenuType.TableStat)
                {

#line default
#line hidden
            BeginContext(1471, 240, true);
            WriteLiteral("                    <a class=\"menu-link active\" href=\"/Admin/TableStat\">\r\n                        <span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span>\r\n                        <span>Table Stat</span>\r\n                    </a>\r\n");
            EndContext();
#line 41 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1771, 233, true);
            WriteLiteral("                    <a class=\"menu-link\" href=\"/Admin/TableStat\">\r\n                        <span class=\"glyphicon glyphicon-home\" aria-hidden=\"true\"></span>\r\n                        <span>Table Stat</span>\r\n                    </a>\r\n");
            EndContext();
#line 48 "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\Partials\Admin\AdminMenusPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(2023, 3643, true);
            WriteLiteral(@"                
            </li>
            <li class=""menu-item"">
                <a class=""menu-link "" href=""#"">
                    <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
                    <span>Auth</span>
                </a>
            </li>
            <li class=""menu-item"">
                <a class=""menu-link "" href=""#"">
                    <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
                    <span>Forms &amp; Components</span>
                </a>
            </li>
            <li class=""menu-item"">
                <a class=""menu-link "" href=""#"">
                    <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
                    <span>Tables</span>
                </a>
            </li>
            <li class=""menu-item"">
                <a class=""menu-link "" href=""#"">
                    <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
                    <span>User Profile</spa");
            WriteLiteral(@"n>
                </a>
            </li>
            <li class=""menu-item"">
                <a class=""menu-link "" href=""#"">
                    <span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
                    <span>Errors</span>
                </a>
            </li>
        </ul>
    </div>
</div>
<style>
    .menu-contain {
        width:16.7%;
        top: 0px;
        position: fixed;
                        height: 100%;
        z-index: 1070;
        box-shadow: rgba(90, 97, 105, 0.1) 0px 0.125rem 9.375rem, rgba(90, 97, 105, 0.12) 0px 0.25rem 0.5rem, rgba(90, 97, 105, 0.1) 0px 0.9375rem 1.375rem, rgba(165, 182, 201, 0.1) 0px 0.4375rem 2.1875rem;
    }
    .mt-title{
        line-height: 25px;
        font-weight: 500;
        font-size: 1rem;
        color: rgba(0,0,0,.9);
                    font-family: -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, sans-serif;
        margin-left: 0.5rem;
        cursor: pointer;
    }");
            WriteLiteral(@"
    .menu {
        width: 100%;
    }

    .menu-title {
        padding: 18px 0;
        border-bottom: 1px solid #e1e5eb;
    }
    .menu-item{
        color: #007bff;
        background-color: #fbfbfb;
        color: #007bff;
        width: 100%;
    }
    .menu-link{
        border-bottom: 1px solid #e1e5eb;
        font-weight: 400;
        color: #3d5170;
        padding: .9375rem 1.5625rem !important;  
    }
    .menu-item:hover{
        background-color: #fbfbfb !important;  
    }
    .menu-item > a:hover{
        box-shadow: inset 0.1875rem 0 0 #007bff;
        background-color: #fbfbfb !important;  
        color: #007bff;
    }
    .menu-item > .active{
        box-shadow: inset 0.1875rem 0 0 #007bff;
        background-color: #fbfbfb !important;  
        color: #007bff;
    }
    .menu-item > .active > .glyphicon{
        color: #007bff;
    }
    .menu-link:hover span{
                    color: #007bff;
    }
    .glyphicon{
        font-size: 1.125r");
            WriteLiteral(@"em;
        top: -1px;
        min-width: 1.25rem;
        font-size: 90%;
        text-align: center;
        vertical-align: middle;
        will-change: color;
        color: #cacedb;
        transition: color .2s ease;
                margin-right: .375rem;
    }
    .glyphicon:hover{
        color: #3d5170;
    }
</style>
<script>
    $(document).ready(function(e){
        $("".menu-item a"").click(function(){
            $("".menu-item a"").removeClass('active')
            $(this).addClass('active')
        });
                });
</script>");
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
