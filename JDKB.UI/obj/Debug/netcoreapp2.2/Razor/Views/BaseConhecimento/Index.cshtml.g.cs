#pragma checksum "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baf4b031c2598d2aed7efaef88e3d6f28fd0cea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaseConhecimento_Index), @"mvc.1.0.view", @"/Views/BaseConhecimento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BaseConhecimento/Index.cshtml", typeof(AspNetCore.Views_BaseConhecimento_Index))]
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
#line 1 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\_ViewImports.cshtml"
using JDKB.UI;

#line default
#line hidden
#line 2 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\_ViewImports.cshtml"
using JDKB.UI.Models;

#line default
#line hidden
#line 3 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\_ViewImports.cshtml"
using JDKB.Domain.Entities;

#line default
#line hidden
#line 2 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
using JDKB.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baf4b031c2598d2aed7efaef88e3d6f28fd0cea4", @"/Views/BaseConhecimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe37d63d81bb41524bd70162778c1404acbe1a9", @"/Views/_ViewImports.cshtml")]
    public class Views_BaseConhecimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<BaseConhecimento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BaseConhecimento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger shadow-sm rounded-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 836, true);
            WriteLiteral(@"    
    <style>
        a, a:hover {
            color: #1a0dab;
        }

        span {
            color: #dc3545; /*#006621;*/
        }

        mark, .mark {
            padding: 0;
            background-color: yellow;
        }

        .search_conteudo {
            font-size: small;
            line-height: 1.4;
            word-wrap: break-word;
        }

        h2 {
            font-size: 18px;
            margin-top: 10px;
            margin-bottom: 0px;
        }

        .tags {
            font-size: x-small;
            margin-bottom: 5px;
            color: darkblue; /*#006621;*/
        }

        .resultStats {
            color: #808080;
        }

        .small, small {
            font-size: 90%;
        }

    </style>

    <div class=""mt-4"">

        ");
            EndContext();
            BeginContext(897, 839, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea46518", async() => {
                BeginContext(935, 257, true);
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" name=""SearchString"" class=""form-control shadow-sm bg-white rounded-left"" placeholder=""Pesquisar por...""
                       aria-label=""Pesquisa"" aria-describedby=""basic-addon2""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1192, "\"", 1226, 1);
#line 51 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
WriteAttributeValue("", 1200, ViewData["CurrentFilter"], 1200, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1227, 154, true);
                WriteLiteral(">\r\n\r\n                <div class=\"input-group-append shadow-sm\">\r\n                    <input type=\"submit\" value=\"Localizar\" class=\"btn btn-primary\" />\r\n\r\n");
                EndContext();
#line 56 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
                BeginContext(1461, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1485, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea48107", async() => {
                    BeginContext(1590, 52, true);
                    WriteLiteral("<span class=\"glyphicon glyphicon-plus-sign\"></span>+");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1646, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1671, 58, true);
                WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1736, 141, true);
            WriteLiteral("\r\n\r\n        <div class=\"col-md-11 col-xs-12 col-sm-12 mt-4\" style=\"padding-left: 0px;\">\r\n\r\n            <div class=\"search_conteudo mt-4\">\r\n\r\n");
            EndContext();
#line 72 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                  
                    if (Model.TotalItens == 0)
                    {

#line default
#line hidden
            BeginContext(2020, 95, true);
            WriteLiteral("                        <small class=\"resultStats\"><i>Nenhum resultado encontrado</i></small>\r\n");
            EndContext();
#line 76 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }
                    else if (Model.TotalItens == 1)
                    {

#line default
#line hidden
            BeginContext(2214, 87, true);
            WriteLiteral("                        <small class=\"resultStats\">Foi encontrado 1 resultado</small>\r\n");
            EndContext();
#line 80 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2373, 69, true);
            WriteLiteral("                        <small class=\"resultStats\">Foram encontrados ");
            EndContext();
            BeginContext(2443, 27, false);
#line 83 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                                                                Write(Model.TotalItens.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2470, 21, true);
            WriteLiteral(" resultados</small>\r\n");
            EndContext();
#line 84 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 87 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                 foreach (var item in Model)
                {
                    // Título

#line default
#line hidden
            BeginContext(2631, 50, true);
            WriteLiteral("                    <h2>\r\n                        ");
            EndContext();
            BeginContext(2681, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea414093", async() => {
                BeginContext(2763, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2794, 62, false);
#line 92 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                       Write(Html.Raw(item.Resumo.Select(t => t.DsTitulo).FirstOrDefault()));

#line default
#line hidden
                EndContext();
                BeginContext(2856, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2886, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 95 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"

                    // Palavra(s) chave

#line default
#line hidden
            BeginContext(2958, 40, true);
            WriteLiteral("                    <div class=\"tags\">\r\n");
            EndContext();
            BeginContext(3034, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3063, 80, false);
#line 99 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                       Write(Html.Raw(item.BuscaChave.Select(t => t.Tags.SplitText(x => x)).FirstOrDefault()));

#line default
#line hidden
            EndContext();
            BeginContext(3143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3182, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 102 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"

                    // Conteúdo do Resumo

#line default
#line hidden
            BeginContext(3255, 99, true);
            WriteLiteral("                    <div class=\"search_conteudo\" style=\"font-size:small\">\r\n                        ");
            EndContext();
            BeginContext(3355, 59, false);
#line 105 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                   Write(Html.Raw(item.Resumo.Select(r => r.Texto).FirstOrDefault()));

#line default
#line hidden
            EndContext();
            BeginContext(3414, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 107 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"

                    // Produto

#line default
#line hidden
            BeginContext(3478, 152, true);
            WriteLiteral("                    <div>\r\n                        <p class=\"text-right\" style=\"font-size: x-small; color: #777\">\r\n                            Produto: ");
            EndContext();
            BeginContext(3631, 66, false);
#line 111 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                                Write(item.BaseProduto.Select(e => e.Produto.NmProduto).FirstOrDefault());

#line default
#line hidden
            EndContext();
            BeginContext(3697, 60, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
            EndContext();
#line 114 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3776, 40, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n\r\n");
            EndContext();
#line 120 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
          
            var firstDisabled = Model.FirstPage ? "disabled" : "";
            var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
            var nextDisabled = !Model.HasNextPage ? "disabled" : "";
            var lastDisabled = Model.LastPage ? "disabled" : "";
        

#line default
#line hidden
            BeginContext(4163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4198, 102, true);
            WriteLiteral("        <div class=\"col-md-offset-6 mt-5\" style=\"position:relative; text-align:center;\">\r\n            ");
            EndContext();
            BeginContext(4300, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea420824", async() => {
                BeginContext(4558, 35, true);
                WriteLiteral("\r\n                |<<\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 130 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 132 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4518, "btn", 4518, 3, true);
            AddHtmlAttributeValue(" ", 4521, "btn-outline-primary", 4522, 20, true);
#line 133 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 4541, firstDisabled, 4542, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4597, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(4611, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea425026", async() => {
                BeginContext(4889, 33, true);
                WriteLiteral("\r\n                <\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 138 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                          WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 139 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4850, "btn", 4850, 3, true);
            AddHtmlAttributeValue(" ", 4853, "btn-outline-primary", 4854, 20, true);
#line 140 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 4873, prevDisabled, 4874, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4926, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(4940, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea429378", async() => {
                BeginContext(5218, 33, true);
                WriteLiteral("\r\n                >\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 144 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 145 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                          WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 146 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5179, "btn", 5179, 3, true);
            AddHtmlAttributeValue(" ", 5182, "btn-outline-primary", 5183, 20, true);
#line 147 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 5202, nextDisabled, 5203, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5255, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(5269, 312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf4b031c2598d2aed7efaef88e3d6f28fd0cea433730", async() => {
                BeginContext(5542, 35, true);
                WriteLiteral("\r\n                >>|\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 151 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 152 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                         WriteLiteral(Model.TotalPages);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 153 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5503, "btn", 5503, 3, true);
            AddHtmlAttributeValue(" ", 5506, "btn-outline-primary", 5507, 20, true);
#line 154 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 5526, lastDisabled, 5527, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5581, 35, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<BaseConhecimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
