#pragma checksum "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be790fcbfe5b138f7a48563cf2fedb7d0771be00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GRC.Application.Pages.Category.Pages_Category_Create), @"mvc.1.0.razor-page", @"/Pages/Category/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Category/Create.cshtml", typeof(GRC.Application.Pages.Category.Pages_Category_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be790fcbfe5b138f7a48563cf2fedb7d0771be00", @"/Pages/Category/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ce8b6a437d18d79d202acc92bc914acb3233f6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Category_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml"
  
    ViewData["Title"] = "Cadastrar Nova Categoria";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(143, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(150, 17, false);
#line 8 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(167, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(174, 835, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fad53b5d9b7424da2f24d80053295aa", async() => {
                BeginContext(194, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(201, 23, false);
#line 10 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(224, 53, true);
                WriteLiteral("\r\n    <div class=\"form-horizontal\">\r\n        <hr />\r\n");
                EndContext();
                BeginContext(366, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(375, 65, false);
#line 14 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(440, 89, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                ");
                EndContext();
                BeginContext(530, 49, false);
#line 17 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Name));

#line default
#line hidden
                EndContext();
                BeginContext(579, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(598, 78, false);
#line 18 "C:\Users\Gabriel.castro\Documents\GitHub\GRC\GRC\Pages\Category\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Category.Name, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(676, 223, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Salvar\" class=\"btn btn-success\" />\r\n                ");
                EndContext();
                BeginContext(899, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83501fbf36574825a0b0c1711b82f9b6", async() => {
                    BeginContext(942, 6, true);
                    WriteLiteral("Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(952, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1009, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GRC.Application.Pages.Category.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Category.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GRC.Application.Pages.Category.CreateModel>)PageContext?.ViewData;
        public GRC.Application.Pages.Category.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
