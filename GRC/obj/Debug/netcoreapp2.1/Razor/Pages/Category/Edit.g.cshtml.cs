#pragma checksum "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "469caeb0c851d501b76ff994c616e8f74feeda98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GRC.Application.Pages.Category.Pages_Category_Edit), @"mvc.1.0.razor-page", @"/Pages/Category/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Category/Edit.cshtml", typeof(GRC.Application.Pages.Category.Pages_Category_Edit), @"{id:int}")]
namespace GRC.Application.Pages.Category
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\_ViewImports.cshtml"
using GRC;

#line default
#line hidden
#line 3 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\_ViewImports.cshtml"
using GRC.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469caeb0c851d501b76ff994c616e8f74feeda98", @"/Pages/Category/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ce8b6a437d18d79d202acc92bc914acb3233f6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Category_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
  
    ViewData["Title"] = "Editar Categoria";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(144, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(149, 17, false);
#line 7 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(166, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(175, 808, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08eefd1a819844e7825137af088aeafa", async() => {
                BeginContext(195, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(202, 23, false);
#line 10 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(225, 61, true);
                WriteLiteral("\r\n    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
                EndContext();
                BeginContext(287, 42, false);
#line 13 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Category.Id));

#line default
#line hidden
                EndContext();
                BeginContext(329, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(342, 65, false);
#line 15 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(407, 89, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                ");
                EndContext();
                BeginContext(497, 49, false);
#line 18 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Name));

#line default
#line hidden
                EndContext();
                BeginContext(546, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(565, 78, false);
#line 19 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Category.Name, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(643, 223, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-success\" />\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 866, "\"", 893, 1);
#line 25 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Edit.cshtml"
WriteAttributeValue("", 873, Url.Page("./Index"), 873, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(894, 82, true);
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
            BeginContext(983, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GRC.Application.Pages.Category.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Category.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Category.EditModel>)PageContext?.ViewData;
        public GRC.Application.Pages.Category.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
