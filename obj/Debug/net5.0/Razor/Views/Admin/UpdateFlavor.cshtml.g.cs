#pragma checksum "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f86f45d0b2f3a32f1d0bd13f51759e0a9d74d3db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateFlavor), @"mvc.1.0.view", @"/Views/Admin/UpdateFlavor.cshtml")]
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
#nullable restore
#line 1 "C:\c_sharp\MochiSweets\MochiSweets\Views\_ViewImports.cshtml"
using MochiSweets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\c_sharp\MochiSweets\MochiSweets\Views\_ViewImports.cshtml"
using MochiSweets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86f45d0b2f3a32f1d0bd13f51759e0a9d74d3db", @"/Views/Admin/UpdateFlavor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d135dab0b312d30e33ad9ea2adafe0a10048b16", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateFlavor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("UpdateFlavor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
  
ViewData["Title"] = "Update Flavor";
Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f86f45d0b2f3a32f1d0bd13f51759e0a9d74d3db5139", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 353, "\"", 363, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 390, "\"", 400, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>MS Admin 2 - Product</title>

    <!-- Latest compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">

    <!-- jQuery library -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!-- Popper JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>

    <!-- Latest compiled JavaScript -->
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

    <link href=""css/add-product.css"" rel=""stylesheet"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f86f45d0b2f3a32f1d0bd13f51759e0a9d74d3db7350", async() => {
                WriteLiteral(@"
    <div class=""container"">

        <section class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title textMain"">UPDATE TASTE</h3>
            </div>
            <div class=""panel-body"">

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f86f45d0b2f3a32f1d0bd13f51759e0a9d74d3db7880", async() => {
                    WriteLiteral("\r\n                  <div class=\"form-group\">\r\n                        <label for=\"name\" class=\"col-sm-3 control-label\">Taste Id : ");
#nullable restore
#line 46 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
                                                                               Write(ViewBag.taste.tasteID);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n                        <div class=\"col-sm-9\">\r\n                            <input hidden name=\"tasteID\"");
                    BeginWriteAttribute("value", " value=\"", 1682, "\"", 1712, 1);
#nullable restore
#line 48 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
WriteAttributeValue("", 1690, ViewBag.taste.tasteID, 1690, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                             <input hidden name=\"categoryID\"");
                    BeginWriteAttribute("value", " value=\"", 1776, "\"", 1803, 1);
#nullable restore
#line 49 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
WriteAttributeValue("", 1784, ViewBag.categoryID, 1784, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""name"" class=""col-sm-3 control-label"">Name Taste</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" name=""tasteName"" id=""name""");
                    BeginWriteAttribute("value", "\r\n                                value=\"", 2148, "\"", 2213, 1);
#nullable restore
#line 56 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
WriteAttributeValue("", 2189, ViewBag.taste.tasteName, 2189, 24, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        </div>
                    </div> <!-- form-group // -->
                    <div class=""form-group"">
                        <label for=""qty"" class=""col-sm-3 control-label"">Quantity</label>
                        <div class=""col-sm-3"">
                            <input type=""text"" class=""form-control"" name=""quantity"" id=""qty""");
                    BeginWriteAttribute("value", "\r\n                                value=\"", 2576, "\"", 2640, 1);
#nullable restore
#line 63 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
WriteAttributeValue("", 2617, ViewBag.taste.quantity, 2617, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                      <div class=\"boxImg boxImgMain\">\r\n                        <img");
                    BeginWriteAttribute("src", " src=\"", 2833, "\"", 2870, 2);
                    WriteAttributeValue("", 2839, "/Admin/img/", 2839, 11, true);
#nullable restore
#line 68 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\UpdateFlavor.cshtml"
WriteAttributeValue("", 2850, ViewBag.taste.image, 2850, 20, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" height=""100%"" width=""200px"" height=""70px"">
                      </div>
                    
                      <div class=""imgText"">
                        <label class=""control-label small"">Choose a new photo to update the main photo
                          (jpg/png):</label>
                        <input type=""file"" name=""image"">
                      </div>
                    </div>

                    <hr>
                    <div class=""form-group"">
                        <div class=""col-sm-offset-3 col-sm-9"">
                            <button type=""submit"" class=""btn btn-primary"">Save</button>
                        </div>
                    </div> <!-- form-group // -->
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div><!-- panel-body // -->\r\n        </section><!-- panel// -->\r\n\r\n\r\n    </div> <!-- container// -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
