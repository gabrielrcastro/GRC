#pragma checksum "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7802f7fa3fd885eba11544d0e94982ec5c9696f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GRC.Application.Pages.Product.Pages_Product_Delete), @"mvc.1.0.razor-page", @"/Pages/Product/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Product/Delete.cshtml", typeof(GRC.Application.Pages.Product.Pages_Product_Delete), @"{id:int}")]
namespace GRC.Application.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\_ViewImports.cshtml"
using GRC;

#line default
#line hidden
#line 3 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\_ViewImports.cshtml"
using GRC.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7802f7fa3fd885eba11544d0e94982ec5c9696f6", @"/Pages/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ce8b6a437d18d79d202acc92bc914acb3233f6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
  
    ViewData["Title"] = "Excluir Produto";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(144, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(151, 17, false);
#line 8 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(177, 770, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "345aa6c909694a4e9ae3e7d3af57bde1", async() => {
                BeginContext(197, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(204, 23, false);
#line 11 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(227, 73, true);
                WriteLiteral("\r\n    <vc:summary />\r\n    <h3>Tem certeza que deseja excluir a categoria ");
                EndContext();
                BeginContext(301, 18, false);
#line 13 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
                                              Write(Model.Product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(319, 27, true);
                WriteLiteral("?</h3>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(347, 41, false);
#line 15 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
   Write(Html.HiddenFor(model => model.Product.Id));

#line default
#line hidden
                EndContext();
                BeginContext(388, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(399, 43, false);
#line 16 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
   Write(Html.HiddenFor(model => model.Product.Name));

#line default
#line hidden
                EndContext();
                BeginContext(442, 88, true);
                WriteLiteral("\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
                EndContext();
                BeginContext(531, 48, false);
#line 20 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.Name));

#line default
#line hidden
                EndContext();
                BeginContext(579, 55, true);
                WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
                EndContext();
                BeginContext(635, 44, false);
#line 23 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Product.Name));

#line default
#line hidden
                EndContext();
                BeginContext(679, 171, true);
                WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" />\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 850, "\"", 877, 1);
#line 28 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Delete.cshtml"
WriteAttributeValue("", 857, Url.Page("./Index"), 857, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(878, 62, true);
                WriteLiteral(" class=\"btn btn-info\">Voltar</a>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(947, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GRC.Application.Pages.Product.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Product.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Product.DeleteModel>)PageContext?.ViewData;
        public GRC.Application.Pages.Product.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591