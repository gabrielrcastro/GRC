#pragma checksum "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2438b4378d9164569639049ebf6a0a699e07cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GRC.Application.Pages.Product.Pages_Product_Edit), @"mvc.1.0.razor-page", @"/Pages/Product/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Product/Edit.cshtml", typeof(GRC.Application.Pages.Product.Pages_Product_Edit), @"{id:int}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2438b4378d9164569639049ebf6a0a699e07cb2", @"/Pages/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ce8b6a437d18d79d202acc92bc914acb3233f6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
  
    ViewData["Title"] = "Editar Produto";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(141, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(146, 17, false);
#line 7 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(163, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(172, 1640, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5a77f3b4a6847a0869de2af459abf68", async() => {
                BeginContext(192, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(199, 23, false);
#line 10 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(222, 61, true);
                WriteLiteral("\r\n    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
                EndContext();
                BeginContext(284, 41, false);
#line 13 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Product.Id));

#line default
#line hidden
                EndContext();
                BeginContext(325, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(338, 65, false);
#line 15 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(403, 48, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(452, 85, false);
#line 17 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.Product.Name, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(537, 54, true);
                WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
                EndContext();
                BeginContext(592, 77, false);
#line 19 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Product.Name, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(669, 86, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(756, 91, false);
#line 24 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.Product.CategoryId, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(847, 54, true);
                WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
                EndContext();
                BeginContext(902, 183, false);
#line 26 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
           Write(Html.DropDownListFor(model => model.Product.CategoryId,
                 new SelectList(Model.Categories, "Id", "Name"), "- Selecione a Categoria -", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1085, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1104, 60, false);
#line 28 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Product.CategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(1164, 86, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(1251, 86, false);
#line 33 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
       Write(Html.LabelFor(model => model.Product.Price, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1337, 54, true);
                WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
                EndContext();
                BeginContext(1392, 78, false);
#line 35 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Product.Price, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1470, 225, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-success\" />\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1695, "\"", 1722, 1);
#line 42 "C:\Users\Gabriel.castro\Documents\Meus Projetos .NET\GRC\GRC\Pages\Product\Edit.cshtml"
WriteAttributeValue("", 1702, Url.Page("./Index"), 1702, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1723, 82, true);
                WriteLiteral(" class=\"btn btn-info\">Voltar</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(1812, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GRC.Application.Pages.Product.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Product.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Product.EditModel>)PageContext?.ViewData;
        public GRC.Application.Pages.Product.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
