#pragma checksum "C:\Users\KienPC\Desktop\New folder\MochiSweets\Views\Shared\_AdminLayoutPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d278338e744e916c95d1a1cd778be5cbe4745b59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayoutPage), @"mvc.1.0.view", @"/Views/Shared/_AdminLayoutPage.cshtml")]
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
#line 1 "C:\Users\KienPC\Desktop\New folder\MochiSweets\Views\_ViewImports.cshtml"
using MochiSweets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KienPC\Desktop\New folder\MochiSweets\Views\_ViewImports.cshtml"
using MochiSweets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d278338e744e916c95d1a1cd778be5cbe4745b59", @"/Views/Shared/_AdminLayoutPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d135dab0b312d30e33ad9ea2adafe0a10048b16", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLayoutPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d278338e744e916c95d1a1cd778be5cbe4745b596336", async() => {
                WriteLiteral("\r\n\r\n  <meta charset=\"utf-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n  <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 246, "\"", 256, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n  <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 281, "\"", 291, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n  <title>");
#nullable restore
#line 11 "C:\Users\KienPC\Desktop\New folder\MochiSweets\Views\Shared\_AdminLayoutPage.cshtml"
    Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </title>\r\n  <title>MS Admin 2 - Dashboard</title>\r\n\r\n  <!-- Custom fonts for this template-->\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d278338e744e916c95d1a1cd778be5cbe4745b597506", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                WriteLiteral("\r\n  <link\r\n    href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\"\r\n    rel=\"stylesheet\">\r\n\r\n  <!-- Custom styles for this template-->\r\n  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d278338e744e916c95d1a1cd778be5cbe4745b598983", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d278338e744e916c95d1a1cd778be5cbe4745b5910874", async() => {
                WriteLiteral(@"

  <!-- Page Wrapper -->
  <div id=""wrapper"">

    <!-- Sidebar -->
    <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

      <!-- Sidebar - Brand -->
      <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""Index"">
        <div class=""sidebar-brand-icon"">
          <img class=""icon-sidebar"" src=""img/logo_small@2x.png"" width=""70px"" height=""70px"">
        </div>
        <div class=""sidebar-brand-text mx-3"">MS Admin <sup>2</sup></div>
      </a>

      <!-- Divider -->
      <hr class=""sidebar-divider my-0"">

      <!-- Nav Item - Dashboard -->
      <li class=""nav-item active"">
        <a class=""nav-link"" href=""Index"">
          <i class=""fas fa-fw fa-tachometer-alt""></i>
          <span>Dashboard</span></a>
      </li>

      <!-- Divider -->
      <hr class=""sidebar-divider"">

      <!-- Heading -->


      <!-- Nav Item - Pages Collapse Menu -->
      <li class=""nav-item"">
        <a class=""nav-");
                WriteLiteral(@"link"" href=""Product"">
          <span>Product</span>
        </a>
      </li>

      <!-- Nav Item - Utilities Collapse Menu -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""category.html"">
          <span>Category</span>
        </a>
      </li>

      <!-- Nav Item - Pages Collapse Menu -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""oder.html"">
          <span>Order</span>
        </a>
      </li>

      <!-- Nav Item - Charts -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""new.html"">
          <span>News</span></a>
      </li>

      <!-- Nav Item - Tables -->
      <li class=""nav-item"">
        <a class=""nav-link"" href=""account.html"">
          <span>Account</span></a>
      </li>

      <li class=""nav-item"">
        <a class=""nav-link"" href=""forgot-password.html"">
          <span>Forgot Password</span></a>
      </li>

      <!-- Divider -->
      <hr class=""sidebar-divider d-none d-md-block"">

      <!-- Sidebar");
                WriteLiteral(@" Toggler (Sidebar) -->
      <div class=""text-center d-none d-md-inline"">
        <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
      </div>

    </ul>

    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

      <!-- Main Content -->
      <div id=""content"">

        <!-- Topbar -->
        <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

          <!-- Sidebar Toggle (Topbar) -->
          <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
            <i class=""fa fa-bars""></i>
          </button>

          <!-- Topbar Search -->
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d278338e744e916c95d1a1cd778be5cbe4745b5914040", async() => {
                    WriteLiteral(@"
            <div class=""input-group"">
              <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                aria-label=""Search"" aria-describedby=""basic-addon2"">
              <div class=""input-group-append"">
                <button class=""btn btn-primary"" type=""button"">
                  <i class=""fas fa-search fa-sm""></i>
                </button>
              </div>
            </div>
          ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

          <!-- Topbar Navbar -->
          <ul class=""navbar-nav ml-auto"">

            <!-- Nav Item - Search Dropdown (Visible Only XS) -->
            <li class=""nav-item dropdown no-arrow d-sm-none"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown""
                aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
              </a>
              <!-- Dropdown - Messages -->
              <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                aria-labelledby=""searchDropdown"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d278338e744e916c95d1a1cd778be5cbe4745b5916591", async() => {
                    WriteLiteral(@"
                  <div class=""input-group"">
                    <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                      aria-label=""Search"" aria-describedby=""basic-addon2"">
                    <div class=""input-group-append"">
                      <button class=""btn btn-primary"" type=""button"">
                        <i class=""fas fa-search fa-sm""></i>
                      </button>
                    </div>
                  </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
              </div>
            </li>

            <!-- Nav Item - Alerts -->
            <li class=""nav-item dropdown no-arrow mx-1"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown""
                aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-fw""></i>
                <!-- Counter - Alerts -->
                <span class=""badge badge-danger badge-counter"">3+</span>
              </a>
              <!-- Dropdown - Alerts -->
              <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                aria-labelledby=""alertsDropdown"">
                <h6 class=""dropdown-header"">
                  Alerts Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""mr-3"">
                    <div class=""icon-circle bg-primary"">
                      <i class=""fas fa-file-a");
                WriteLiteral(@"lt text-white""></i>
                    </div>
                  </div>
                  <div>
                    <div class=""small text-gray-500"">December 12, 2019</div>
                    <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""mr-3"">
                    <div class=""icon-circle bg-success"">
                      <i class=""fas fa-donate text-white""></i>
                    </div>
                  </div>
                  <div>
                    <div class=""small text-gray-500"">December 7, 2019</div>
                    $290.29 has been deposited into your account!
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""mr-3"">
                    <div class=""icon-circle bg-warning"">
             ");
                WriteLiteral(@"         <i class=""fas fa-exclamation-triangle text-white""></i>
                    </div>
                  </div>
                  <div>
                    <div class=""small text-gray-500"">December 2, 2019</div>
                    Spending Alert: We've noticed unusually high spending for your account.
                  </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
              </div>
            </li>

            <!-- Nav Item - Messages -->
            <li class=""nav-item dropdown no-arrow mx-1"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button"" data-toggle=""dropdown""
                aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-envelope fa-fw""></i>
                <!-- Counter - Messages -->
                <span class=""badge badge-danger badge-counter"">7</span>
              </a>
              <!-- Dropdown - Messages -->");
                WriteLiteral(@"
              <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                aria-labelledby=""messagesDropdown"">
                <h6 class=""dropdown-header"">
                  Message Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""img/undraw_profile_1.svg""");
                BeginWriteAttribute("alt", " alt=\"", 8926, "\"", 8932, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""status-indicator bg-success""></div>
                  </div>
                  <div class=""font-weight-bold"">
                    <div class=""text-truncate"">Hi there! I am wondering if you can help me with a
                      problem I've been having.</div>
                    <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""img/undraw_profile_2.svg""");
                BeginWriteAttribute("alt", " alt=\"", 9576, "\"", 9582, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""status-indicator""></div>
                  </div>
                  <div>
                    <div class=""text-truncate"">I have the photos that you ordered last month, how
                      would you like them sent to you?</div>
                    <div class=""small text-gray-500"">Jae Chun · 1d</div>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""img/undraw_profile_3.svg""");
                BeginWriteAttribute("alt", " alt=\"", 10192, "\"", 10198, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""status-indicator bg-warning""></div>
                  </div>
                  <div>
                    <div class=""text-truncate"">Last month's report looks great, I am very happy with
                      the progress so far, keep up the good work!</div>
                    <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                  </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                  <div class=""dropdown-list-image mr-3"">
                    <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""");
                BeginWriteAttribute("alt", " alt=\"", 10860, "\"", 10866, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""status-indicator bg-success""></div>
                  </div>
                  <div>
                    <div class=""text-truncate"">Am I a good boy? The reason I ask is because someone
                      told me that people say this to all dogs, even if they aren't good...</div>
                    <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                  </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
              </div>
            </li>

            <div class=""topbar-divider d-none d-sm-block""></div>

            <!-- Nav Item - User Information -->
            <li class=""nav-item dropdown no-arrow"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown""
                aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">HK");
                WriteLiteral(@"T Team</span>
                <img class=""img-profile rounded-circle"" src=""img/profile.jpg"">
              </a>
              <!-- Dropdown - User Information -->
              <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""#"">
                  <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                  Profile
                </a>
                <a class=""dropdown-item"" href=""#"">
                  <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                  Settings
                </a>
                <a class=""dropdown-item"" href=""#"">
                  <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                  Activity Log
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                  <i class=""fas fa-sign-ou");
                WriteLiteral("t-alt fa-sm fa-fw mr-2 text-gray-400\"></i>\r\n                  Logout\r\n                </a>\r\n              </div>\r\n            </li>\r\n\r\n          </ul>\r\n\r\n        </nav>\r\n        <!-- End of Topbar -->\r\n\r\n        <!-- Begin Page Content -->\r\n        ");
#nullable restore
#line 308 "C:\Users\KienPC\Desktop\New folder\MochiSweets\Views\Shared\_AdminLayoutPage.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

      </div>
      <!-- Bootstrap core JavaScript-->
      <script src=""vendor/jquery/jquery.min.js""></script>
      <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

      <!-- Core plugin JavaScript-->
      <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

      <!-- Custom scripts for all pages-->
      <script src=""js/sb-admin-2.min.js""></script>

      <!-- Page level plugins -->
      <script src=""vendor/chart.js/Chart.min.js""></script>

      <!-- Page level custom scripts -->
      <script src=""js/demo/chart-area-demo.js""></script>
      <script src=""js/demo/chart-pie-demo.js""></script>
    </div>
  </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
