#pragma checksum "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58faf4453625282a114d9336115f016fc7bc8f4f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58faf4453625282a114d9336115f016fc7bc8f4f", @"/Views/BaseConhecimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe37d63d81bb41524bd70162778c1404acbe1a9", @"/Views/_ViewImports.cshtml")]
    public class Views_BaseConhecimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<BaseConhecimento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BaseConhecimento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 832, true);
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
            BeginContext(893, 799, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f6490", async() => {
                BeginContext(931, 225, true);
                WriteLiteral("\r\n            <div class=\"input-group\">\r\n                <input type=\"text\" name=\"SearchString\" class=\"form-control\" placeholder=\"Pesquisar por...\"\r\n                       aria-label=\"Pesquisa\" aria-describedby=\"basic-addon2\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1156, "\"", 1190, 1);
#line 51 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
WriteAttributeValue("", 1164, ViewData["CurrentFilter"], 1164, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1191, 144, true);
                WriteLiteral(">\r\n\r\n                <div class=\"input-group-append\">\r\n                    <input type=\"submit\" value=\"Localizar\" class=\"btn btn-primary\" />\r\n\r\n");
                EndContext();
#line 56 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
                BeginContext(1415, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1439, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f8042", async() => {
                    BeginContext(1520, 52, true);
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
                BeginContext(1576, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }                            

#line default
#line hidden
                BeginContext(1629, 56, true);
                WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        ");
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
            BeginContext(1692, 141, true);
            WriteLiteral("\r\n\r\n        <div class=\"col-md-11 col-xs-12 col-sm-12 mt-4\" style=\"padding-left: 0px;\">\r\n\r\n            <div class=\"search_conteudo mt-4\">\r\n\r\n");
            EndContext();
#line 71 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                  
                    if (Model.TotalItens == 0)
                    {

#line default
#line hidden
            BeginContext(1976, 95, true);
            WriteLiteral("                        <small class=\"resultStats\"><i>Nenhum resultado encontrado</i></small>\r\n");
            EndContext();
#line 75 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }
                    else if (Model.TotalItens == 1)
                    {

#line default
#line hidden
            BeginContext(2170, 87, true);
            WriteLiteral("                        <small class=\"resultStats\">Foi encontrado 1 resultado</small>\r\n");
            EndContext();
#line 79 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2329, 69, true);
            WriteLiteral("                        <small class=\"resultStats\">Foram encontrados ");
            EndContext();
            BeginContext(2399, 27, false);
#line 82 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                                                                Write(Model.TotalItens.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2426, 21, true);
            WriteLiteral(" resultados</small>\r\n");
            EndContext();
#line 83 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2489, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                 foreach (var item in Model)
                {
                    // Título

#line default
#line hidden
            BeginContext(2587, 50, true);
            WriteLiteral("                    <h2>\r\n                        ");
            EndContext();
            BeginContext(2637, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f14052", async() => {
                BeginContext(2719, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2750, 62, false);
#line 91 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                       Write(Html.Raw(item.Resumo.Select(t => t.DsTitulo).FirstOrDefault()));

#line default
#line hidden
                EndContext();
                BeginContext(2812, 26, true);
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
#line 90 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
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
            BeginContext(2842, 29, true);
            WriteLiteral("\r\n                    </h2>\r\n");
            EndContext();
#line 94 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"

                    // Palavra(s) chave

#line default
#line hidden
            BeginContext(2914, 40, true);
            WriteLiteral("                    <div class=\"tags\">\r\n");
            EndContext();
            BeginContext(2990, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3019, 80, false);
#line 98 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                       Write(Html.Raw(item.BuscaChave.Select(t => t.Tags.SplitText(x => x)).FirstOrDefault()));

#line default
#line hidden
            EndContext();
            BeginContext(3099, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3138, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 101 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"

                    // Conteúdo do Resumo

#line default
#line hidden
            BeginContext(3211, 99, true);
            WriteLiteral("                    <div class=\"search_conteudo\" style=\"font-size:small\">\r\n                        ");
            EndContext();
            BeginContext(3311, 59, false);
#line 104 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                   Write(Html.Raw(item.Resumo.Select(r => r.Texto).FirstOrDefault()));

#line default
#line hidden
            EndContext();
            BeginContext(3370, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 106 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"

                    // Produto

#line default
#line hidden
            BeginContext(3434, 152, true);
            WriteLiteral("                    <div>\r\n                        <p class=\"text-right\" style=\"font-size: x-small; color: #777\">\r\n                            Produto: ");
            EndContext();
            BeginContext(3587, 66, false);
#line 110 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                                Write(item.BaseProduto.Select(e => e.Produto.NmProduto).FirstOrDefault());

#line default
#line hidden
            EndContext();
            BeginContext(3653, 60, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
            EndContext();
#line 113 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3732, 40, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n\r\n");
            EndContext();
#line 119 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
          
            var firstDisabled = Model.FirstPage ? "disabled" : "";
            var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
            var nextDisabled = !Model.HasNextPage ? "disabled" : "";
            var lastDisabled = Model.LastPage ? "disabled" : "";
        

#line default
#line hidden
            BeginContext(4119, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4154, 102, true);
            WriteLiteral("        <div class=\"col-md-offset-6 mt-5\" style=\"position:relative; text-align:center;\">\r\n            ");
            EndContext();
            BeginContext(4256, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f20783", async() => {
                BeginContext(4514, 35, true);
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
#line 129 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
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
#line 131 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4474, "btn", 4474, 3, true);
            AddHtmlAttributeValue(" ", 4477, "btn-outline-primary", 4478, 20, true);
#line 132 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 4497, firstDisabled, 4498, 14, false);

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
            BeginContext(4553, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(4567, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f24985", async() => {
                BeginContext(4845, 33, true);
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
#line 136 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 137 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                          WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 138 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4806, "btn", 4806, 3, true);
            AddHtmlAttributeValue(" ", 4809, "btn-outline-primary", 4810, 20, true);
#line 139 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 4829, prevDisabled, 4830, 13, false);

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
            BeginContext(4882, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(4896, 315, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f29337", async() => {
                BeginContext(5174, 33, true);
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
#line 143 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 144 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                          WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 145 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5135, "btn", 5135, 3, true);
            AddHtmlAttributeValue(" ", 5138, "btn-outline-primary", 5139, 20, true);
#line 146 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 5158, nextDisabled, 5159, 13, false);

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
            BeginContext(5211, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(5225, 312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58faf4453625282a114d9336115f016fc7bc8f4f33689", async() => {
                BeginContext(5498, 35, true);
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
#line 150 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 151 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                         WriteLiteral(Model.TotalPages);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 152 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5459, "btn", 5459, 3, true);
            AddHtmlAttributeValue(" ", 5462, "btn-outline-primary", 5463, 20, true);
#line 153 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\BaseConhecimento\Index.cshtml"
AddHtmlAttributeValue(" ", 5482, lastDisabled, 5483, 13, false);

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
            BeginContext(5537, 35, true);
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
