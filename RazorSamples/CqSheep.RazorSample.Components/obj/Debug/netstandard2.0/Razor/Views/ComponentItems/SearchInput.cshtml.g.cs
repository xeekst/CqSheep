#pragma checksum "D:\codes\CqSheep\RazorSamples\CqSheep.RazorSample.Components\Views\ComponentItems\SearchInput.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43131fa7d2aaee8bf625d3a6c76a1d0c4e5d45b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComponentItems_SearchInput), @"mvc.1.0.view", @"/Views/ComponentItems/SearchInput.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComponentItems/SearchInput.cshtml", typeof(AspNetCore.Views_ComponentItems_SearchInput))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43131fa7d2aaee8bf625d3a6c76a1d0c4e5d45b", @"/Views/ComponentItems/SearchInput.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_ComponentItems_SearchInput : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 861, true);
            WriteLiteral(@"<div class=""component-searchInput"">
    <span class=""glyphicon glyphicon-search"" aria-hidden=""true""></span>
    <input class=""componentItems-searchInput"" type=""search"" placeholder=""输入你想搜索的"" />
</div>
<style>
    .component-searchInput {
         margin-left: 2.3rem;
         width:100%;
    }

    .componentItems-searchInput {
        width:95%;
        padding: 0rem 0.75rem;
        font-size: .8125rem;
        line-height: 1.5;
        color: #495057;
        background-color: #fff;
        border: 0px solid #e1e5eb;
        font-weight: 300;
        will-change: border-color,box-shadow;
        border-radius: .25rem;
        box-shadow: none;
        transition: box-shadow 250ms cubic-bezier(.27,.01,.38,1.06),border 250ms cubic-bezier(.27,.01,.38,1.06);
        height: 1.75rem;
        border-radius: 1rem;
    }
</style>");
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
