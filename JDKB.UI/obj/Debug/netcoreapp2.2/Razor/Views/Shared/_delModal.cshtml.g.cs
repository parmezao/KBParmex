#pragma checksum "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Shared\_delModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "609c55cd242c8bca937468c5b999e3cf3d4b98df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__delModal), @"mvc.1.0.view", @"/Views/Shared/_delModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_delModal.cshtml", typeof(AspNetCore.Views_Shared__delModal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"609c55cd242c8bca937468c5b999e3cf3d4b98df", @"/Views/Shared/_delModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe37d63d81bb41524bd70162778c1404acbe1a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__delModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1028, true);
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""delModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Excluir</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Deseja excluir o(a) <span id=""dataTipo""></span> <span id=""nome-item"" class=""badge badge-secondary""></span>?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <button type=""button"" class=""btn btn-danger"" onclick=""confirmarDel()"">Confirmar</button>
            </div>
        </div>
    </div>
</");
            WriteLiteral("div>");
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
