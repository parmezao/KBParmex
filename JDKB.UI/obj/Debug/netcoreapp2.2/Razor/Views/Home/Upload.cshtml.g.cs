#pragma checksum "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbe01acf01ee2674ed8af7b1e82e52b5b1ff274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Upload), @"mvc.1.0.view", @"/Views/Home/Upload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Upload.cshtml", typeof(AspNetCore.Views_Home_Upload))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbe01acf01ee2674ed8af7b1e82e52b5b1ff274", @"/Views/Home/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe37d63d81bb41524bd70162778c1404acbe1a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JDKB.Domain.Entities.Anexo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmUpload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dropzone/dropzone.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
  
    ViewData["Title"] = "Upload";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 1140, true);
            WriteLiteral(@"
<style>

    .dropzone {
        margin-bottom: 10px;
        border: dashed;
        min-height: 250px;
    }

</style>

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

    #pesquisa {
        border-radius: 3rem;
        padding: 1rem;
    }

    .form-signin .btn {
        border-radius: 3rem;        
    }

    .form-control {
        font-size:14px;
    }

    .rounded {
        border-");
            WriteLiteral("radius: 3rem !important;\r\n    }\r\n\r\n</style>\r\n\r\n<label for=\"Anexos\" class=\"control-label col-sm-1\">Anexos</label>\r\n\r\n");
            EndContext();
            BeginContext(1234, 303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbe01acf01ee2674ed8af7b1e82e52b5b1ff2747923", async() => {
                BeginContext(1343, 187, true);
                WriteLiteral("\r\n    <div class=\"dropzone\" id=\"my-dropzone\" name=\"mainFileUploader\">\r\n        <div class=\"fallback\">\r\n            <input name=\"file\" type=\"file\" multiple />\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            BeginContext(1537, 413, true);
            WriteLiteral(@"

<div>
    <button type=""submit"" id=""submit-all""> upload </button>
</div>
<br />

<h2>Arquivos</h2>
<div>
    <table id=""Table"" class=""table table-striped table-hover table-bordered table-sm mt-4"" cellspacing=""0"" width=""100%"">
        <thead class=""thead-dark"">
            <tr>
                <th>Arquivo</th>
                <th>Id</th>
            </tr>
        </thead>

        <tbody>

");
            EndContext();
#line 104 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
             foreach (var anexo in Model)
            {

#line default
#line hidden
            BeginContext(2008, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2080, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbe01acf01ee2674ed8af7b1e82e52b5b1ff27411121", async() => {
                BeginContext(2175, 17, false);
#line 108 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
                                                                                                                 Write(anexo.NomeArquivo);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 108 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
AddHtmlAttributeValue("", 2089, anexo.Arquivo, 2089, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
                                                                                               WriteLiteral(anexo.Id);

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
            BeginContext(2196, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(2250, 8, false);
#line 110 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
                   Write(anexo.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2258, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 112 "D:\DotNet\Repositorios\KBParmex\JDKB.UI\Views\Home\Upload.cshtml"
            }

#line default
#line hidden
            BeginContext(2303, 44, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2347, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbe01acf01ee2674ed8af7b1e82e52b5b1ff27415003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2401, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2403, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbe01acf01ee2674ed8af7b1e82e52b5b1ff27416183", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2458, 3400, true);
            WriteLiteral(@"
<script>

    //$(document).ready(function () {

    //    $.ajax({
    //        type: 'GET',
    //        url: '/Home/Upload',
    //        //contentType: ""application/html; charset=utf-8"",  
    //        //dataType: ""html"",  
    //        success: function (data) {  

    //            //alert(JSON.stringify(data));                  
    //            //$(""#DIV"").html('');   
    //            //var DIV = '';  

    //            $.each(data, function (i, item) {  
    //                var rows = ""<tbody><tr>"" +  
    //                    ""<td id='Arquivo'>"" + item.Arquivo + ""</td>"" +  
    //                    ""<td id='Id'>"" + item.Id + ""</td>"" +    
    //                    ""</tr></tbody>"";  
    //                $('#Table').append(rows);  
    //            });
                
    //            console.log(data);  
    //        },
  
    //        failure: function (data) {  
    //            alert(data.responseText);  
    //        },

    //        error: f");
            WriteLiteral(@"unction (data) {  
    //            alert(data.responseText);  
    //        }
    //    });

    //});

    function Enviar() {
        $(""form#frmUpload"").submit();
    };

    Dropzone.options.myDropzone = {
        url: ""/Home/UploadFile"",
        autoProcessQueue: false,
        uploadMultiple: true,
        parallelUploads: 100,
        maxFiles: 100,
        acceptedFiles: ""image/*,application/pdf,application/vnd.openxmlformats-officedocument.wordprocessingml.document,application/docx,application/msword"",
        addRemoveLinks: true,
        dictDefaultMessage: ""<strong>Arraste os arquivos aqui ou clique para upload.</strong>"",

        init: function () {

            var submitButton = document.querySelector(""#submit-all"");
            var wrapperThis = this;

            submitButton.addEventListener(""click"", function () {
                wrapperThis.processQueue();
            });

            this.on(""complete"", function (data) {
                $("".dz-remove"").ht");
            WriteLiteral(@"ml(""<div><span class='fa fa-trash text-danger' style='font-size: 1.5em'></span></div>"");
            });

            this.on(""maxfilesexceeded"", function (file) {
                this.removeFile(file);
            });

            //this.on(""addedfile"", function (file) {

            //    // Create the remove button
            //    var removeButton = Dropzone.createElement(""<button class='btn btn-lg dark'>Remover</button>"");

            //    // Listen to the click event
            //    removeButton.addEventListener(""click"", function (e) {
            //        // Make sure the button click doesn't submit the form:
            //        e.preventDefault();
            //        e.stopPropagation();

            //        // Remove the file preview.
            //        wrapperThis.removeFile(file);
            //        // If you want to the delete the file on the server as well,
            //        // you can do the AJAX request here.
            //    });

            //   ");
            WriteLiteral(@" // Add the button to the file preview element.
            //    file.previewElement.appendChild(removeButton);
            //});

            //this.on('sendingmultiple', function (data, xhr, formData) {
            //    formData.append(""Username"", $(""#Username"").val());
            //});
        }
    };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JDKB.Domain.Entities.Anexo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
