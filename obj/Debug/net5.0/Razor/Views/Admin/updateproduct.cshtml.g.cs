#pragma checksum "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e7edd93b79290aa3b4573bfae85c3de1ea0c8cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_updateproduct), @"mvc.1.0.view", @"/Views/Admin/updateproduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7edd93b79290aa3b4573bfae85c3de1ea0c8cd", @"/Views/Admin/updateproduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d135dab0b312d30e33ad9ea2adafe0a10048b16", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_updateproduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/updateproduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
  
    ViewData["Title"] = "ProductDetail";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7edd93b79290aa3b4573bfae85c3de1ea0c8cd4831", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 359, "\"", 369, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 396, "\"", 406, 0);
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

    <link href=""css/updateproduct.css"" rel=""stylesheet"">

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7edd93b79290aa3b4573bfae85c3de1ea0c8cd7044", async() => {
                WriteLiteral(@"
    <div class=""container"">

        <section class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">PRODUCT DETAL</h3>
            </div>
            <div class=""panel-body"">

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e7edd93b79290aa3b4573bfae85c3de1ea0c8cd7566", async() => {
                    WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label for=\"name\" class=\"col-sm-3 control-label\"> Category</label>\r\n                        <div class=\"col-sm-9\">\r\n");
#nullable restore
#line 47 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                             foreach (var item in ViewBag.listCategory)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                 if (item.categoryID == ViewBag.product.categoryID)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <label class=\"radio-inline\">\r\n                                        <input type=\"radio\" checked name=\"categoryID\" id=\"inlineRadio1\"");
                    BeginWriteAttribute("value", "\r\n                                    value=\"", 1991, "\"", 2052, 1);
#nullable restore
#line 53 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
WriteAttributeValue("", 2036, item.categoryID, 2036, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        ");
#nullable restore
#line 54 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                   Write(item.categoryName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </label>\r\n");
#nullable restore
#line 56 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <label class=\"radio-inline\">\r\n                                        <input type=\"radio\" name=\"categoryID\" id=\"inlineRadio1\"");
                    BeginWriteAttribute("value", " value=\"", 2431, "\"", 2455, 1);
#nullable restore
#line 60 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
WriteAttributeValue("", 2439, item.categoryID, 2439, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        ");
#nullable restore
#line 61 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                   Write(item.categoryName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                    </label>\r\n");
#nullable restore
#line 63 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                 

                            }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        </div>
                    </div>
                    <div class=""form-group"">
                        <label for=""name"" class=""col-sm-3 control-label"">Name Product</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" name=""productName"" id=""name""");
                    BeginWriteAttribute("value", "\r\n                                value=\"", 2978, "\"", 3047, 1);
#nullable restore
#line 72 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
WriteAttributeValue("", 3019, ViewBag.product.productName, 3019, 28, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        </div>
                    </div> <!-- form-group // -->
                    <div class=""form-group"">
                        <label for=""about"" class=""col-sm-3 control-label"">Descreption</label>
                        <div class=""col-sm-9"">
                            <textarea class=""form-control"" name=""detail"">");
#nullable restore
#line 78 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                                                                    Write(ViewBag.product.detail);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</textarea>
                        </div>
                    </div>


                    <div class=""form-group"">
                        <label for=""qty"" class=""col-sm-3 control-label"">Amount</label>
                        <div class=""col-sm-3"">
                            <input type=""number"" min=""0"" class=""form-control"" name=""price"" id=""qty""");
                    BeginWriteAttribute("value", "\r\n                                value=\"", 3777, "\"", 3840, 1);
#nullable restore
#line 87 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
WriteAttributeValue("", 3818, ViewBag.product.price, 3818, 22, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        </div>
                    </div>
                    <!-- form-group // -->
                    <div class=""form-group"">
                        <label for=""qty"" class=""col-sm-3 control-label"">Quantity</label>
                        <div class=""col-sm-3"">
                            <input type=""text"" class=""form-control"" name=""quantity"" id=""qty""");
                    BeginWriteAttribute("value", "\r\n                                value=\"", 4224, "\"", 4290, 1);
#nullable restore
#line 95 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
WriteAttributeValue("", 4265, ViewBag.product.quantity, 4265, 25, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        </div>
                    </div> <!-- form-group // -->
                    <!-- form-group // -->
                    <div class=""form-group"">
                        <label for=""name"" class=""col-sm-3 control-label"">Images Product</label>
");
#nullable restore
#line 105 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                         foreach (var i in ViewBag.ListImage)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                             if (ViewBag.product.productID == i.productID)
                            {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                <td><img");
                    BeginWriteAttribute("src", " src=\"", 5061, "\"", 5078, 1);
#nullable restore
#line 109 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
WriteAttributeValue("", 5067, i.imageUrl, 5067, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" width=\"100px\" height=\"70px\"></td>\r\n");
#nullable restore
#line 110 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\updateproduct.cshtml"
                             

                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                        <div class=""form-group"">
                            <label class=""col-sm-3 control-label"">Sale Time</label>
                            <div class=""col-sm-3"">
                                <label class=""control-label small"" for=""date_start"">Start: </label>
                                <input type=""text"" class=""form-control"" name=""date_start"" id=""date_start""
                                    placeholder=""date_start"">
                            </div>
                            <div class=""col-sm-3"">
                                <label class=""control-label small"" for=""date_finish"">Finish:</label>
                                <input type=""text"" class=""form-control"" name=""date_finish"" id=""date_finish""
                                    placeholder=""date_finish"">
                            </div>
                            <div class=""col-sm-3"">
                                <label class=""control-label small"" for=""price"">Price Sale:</label>
               ");
                    WriteLiteral(@"                 <input type=""text"" class=""form-control"" name=""price_sale"" id=""price_sale""
                                    placeholder=""price_sale"">
                            </div>
                        </div>
                        <div class=""col-sm-3"">
                            <label class=""control-label small"" for=""file_img"">Files:</label> <input type=""file""
                                name=""file_archive"">
                        </div>
                    </div><!-- form-group -->
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div><!-- panel-body // -->\r\n        </section><!-- panel// -->\r\n\r\n\r\n    </div> <!-- container// -->\r\n");
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
