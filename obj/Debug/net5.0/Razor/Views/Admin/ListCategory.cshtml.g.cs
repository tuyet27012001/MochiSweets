#pragma checksum "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3aa56a94dc024837c1ea66213d44bd0676661e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListCategory), @"mvc.1.0.view", @"/Views/Admin/ListCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3aa56a94dc024837c1ea66213d44bd0676661e", @"/Views/Admin/ListCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d135dab0b312d30e33ad9ea2adafe0a10048b16", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxSe d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
  
    ViewData["Title"] = "ListCategory";
    Layout = "~/Views/Shared/_AdminLayoutPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3aa56a94dc024837c1ea66213d44bd0676661e4201", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 360, "\"", 370, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 397, "\"", 407, 0);
                EndWriteAttribute();
                WriteLiteral(@">

    <title>MS Admin 2 - Product</title>

    <!-- Latest compiled and minified CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <link href=""css/list-product.css"" rel=""stylesheet"">
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
");
                WriteLiteral(@"
    <!-- Custom styles for this template-->
    <link href=""css/sb-admin-2.min.css"" rel=""stylesheet"">
    <!-- jQuery library -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!-- Popper JS -->
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>

    <!-- Latest compiled JavaScript -->
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3aa56a94dc024837c1ea66213d44bd0676661e6653", async() => {
                WriteLiteral(@"
    <div class=""container mt-5"">
        <div class=""textL"">
            <h1>List Category</h1>
        </div>
        <div class=""boxS"">
            <div>
                <a href=""AddCategory"" class=""btn btn-primary btn-block text-uppercase mb-3"" id=""boxAdd"">Add new
                    category</a>
            </div>
            <div>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3aa56a94dc024837c1ea66213d44bd0676661e7286", async() => {
                    WriteLiteral(@"

                    <div id=""box-search"" class=""input-group inputG"">
                        <input type=""text"" name=""search"" class=""form-control bg-light border-0 small""
                            placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2""");
                    BeginWriteAttribute("value", "\r\n                            value=\"", 2223, "\"", 2275, 1);
#nullable restore
#line 57 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 2260, ViewBag.search, 2260, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""submit"">
                                <i class=""fas fa-search fa-sm""></i>
                            </button>
                        </div>
                    </div>
");
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>

        <table class=""table  tm-table-small tm-product-table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">CATEGORY NAME</th>
                    <th scope=""col"">NUMBER OF FLAVORS</th>
");
                WriteLiteral("                    <th scope=\"col\">NUMBER OF PRODUCTS</th>\r\n                    <th scope=\"col\"></th>\r\n                    <th scope=\"col\">&nbsp;</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 94 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                 foreach (var item in ViewBag.listCategory)
                {
                    int i = 0;
                    int j = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 99 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                       Write(item.categoryID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td class=\"tm-product-name\"><a href=\"#\"\r\n                            class=\"text-a\">");
#nullable restore
#line 101 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                      Write(item.categoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                            \r\n");
#nullable restore
#line 103 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                             foreach (var item1 in ViewBag.listTaste)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                 if (item.categoryID == item1.categoryID)
                                {
                                    i++;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>");
#nullable restore
#line 110 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 111 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                         foreach (var item2 in ViewBag.listProduct)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                 if (item.categoryID == item2.categoryID)
                                {
                                    j++;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                             <td>");
#nullable restore
#line 118 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                            Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 4957, "\"", 5013, 2);
                WriteAttributeValue("", 4964, "/Admin/updateCategory?categoryID=", 4964, 33, true);
#nullable restore
#line 119 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 4997, item.categoryID, 4997, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"boxAction\">Sửa</a>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5072, "\"", 5128, 2);
                WriteAttributeValue("", 5079, "/Admin/deleteCategory?categoryID=", 5079, 33, true);
#nullable restore
#line 120 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 5112, item.categoryID, 5112, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"boxAction\">Xóa</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 123 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n        <p>page : ");
#nullable restore
#line 127 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
             Write(ViewBag.page);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 127 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                             Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <div class=\"boxLimit\">\r\n");
#nullable restore
#line 130 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
             if (@ViewBag.page != 1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"boxNext\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 5478, "\"", 5536, 4);
                WriteAttributeValue("", 5485, "?search=", 5485, 8, true);
#nullable restore
#line 133 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 5493, ViewBag.search, 5493, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5508, "&&page=", 5508, 7, true);
#nullable restore
#line 133 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 5515, ViewBag.previousPage, 5515, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                        class=\"fas fa-angle-double-left\"></i></a>\r\n                </div>\r\n");
#nullable restore
#line 136 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
             if (@ViewBag.page != 1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"boxNum\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 5761, "\"", 5819, 4);
                WriteAttributeValue("", 5768, "?search=", 5768, 8, true);
#nullable restore
#line 140 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 5776, ViewBag.search, 5776, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5791, "&&page=", 5791, 7, true);
#nullable restore
#line 140 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 5798, ViewBag.previousPage, 5798, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 140 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                                                             Write(ViewBag.previousPage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 142 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
             if (@ViewBag.total != 1 || @ViewBag.page == 1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"boxNum boxC\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 6030, "\"", 6080, 4);
                WriteAttributeValue("", 6037, "?search=", 6037, 8, true);
#nullable restore
#line 147 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 6045, ViewBag.search, 6045, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6060, "&&page=", 6060, 7, true);
#nullable restore
#line 147 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 6067, ViewBag.page, 6067, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 147 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                                                     Write(ViewBag.page);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 149 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
             if ((@ViewBag.total != 2 || (@ViewBag.page == 1 && @ViewBag.total != 1)) && @ViewBag.nextPage <=
            @ViewBag.total)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"boxNum\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 6355, "\"", 6409, 4);
                WriteAttributeValue("", 6362, "?search=", 6362, 8, true);
#nullable restore
#line 154 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 6370, ViewBag.search, 6370, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6385, "&&page=", 6385, 7, true);
#nullable restore
#line 154 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 6392, ViewBag.nextPage, 6392, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 154 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
                                                                         Write(ViewBag.nextPage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 156 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 158 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
             if (@ViewBag.page != @ViewBag.total && @ViewBag.total != 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"boxNext\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 6625, "\"", 6679, 4);
                WriteAttributeValue("", 6632, "?search=", 6632, 8, true);
#nullable restore
#line 161 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 6640, ViewBag.search, 6640, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6655, "&&page=", 6655, 7, true);
#nullable restore
#line 161 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
WriteAttributeValue("", 6662, ViewBag.nextPage, 6662, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i\r\n                        class=\"fas fa-angle-double-right\"></i></a>\r\n                </div>\r\n");
#nullable restore
#line 164 "C:\c_sharp\MochiSweets\MochiSweets\Views\Admin\ListCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
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