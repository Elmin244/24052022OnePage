#pragma checksum "C:\Users\Lenovo\Desktop\onepage-main\onepage323223\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e32c7cb0e1ae8891d853cfd30b029d7cff81aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\onepage-main\onepage323223\Views\_ViewImports.cshtml"
using onepage323223;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\onepage-main\onepage323223\Views\_ViewImports.cshtml"
using onepage323223.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e32c7cb0e1ae8891d853cfd30b029d7cff81aa", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc84c9632d7a7d643a80bf681777f9c41d449ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e32c7cb0e1ae8891d853cfd30b029d7cff81aa3887", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <link rel=""stylesheet""
          href=""https://unpkg.com/swiper/swiper-bundle.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""assets/css/stylescss.css"">

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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e32c7cb0e1ae8891d853cfd30b029d7cff81aa5546", async() => {
                WriteLiteral(@"
    <header>
        <div class=""box"">
            <div class=""container"">
                <div class=""row"">
                    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                        <div class=""container-fluid"">
                            <a class=""navbar-brand"" href=""#"">Navbar</a>
                            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                <span class=""navbar-toggler-icon""></span>
                            </button>
                            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
                            ");
                WriteLiteral(@"        </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""#"">Link</a>
                                    </li>
                                    <li class=""nav-item dropdown"">
                                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            Dropdown
                                        </a>
                                        <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                            <li><a class=""dropdown-item"" href=""#"">Action</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                                            <li><hr class=""dropdown-divider""></li>
                                            <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
 ");
                WriteLiteral(@"                                       </ul>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link disabled"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Disabled</a>
                                    </li>
                                </ul>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e32c7cb0e1ae8891d853cfd30b029d7cff81aa8396", async() => {
                    WriteLiteral(@"
                                    <input class=""form-control me-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                                    <button class=""btn btn-outline-success"" type=""submit"">Search</button>
                                ");
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
                    </nav>
                    <div class=""classbox"">
                        <div class=""col-md-6 classheader1"">
                            <h1>Awesome App</h1>
                            <h1>App Landing Template</h1>
                            <p>An awesome landing page template to showcase your app features, screenshots, pricing, user testimonials and download links.</p>
                            <i class=""fa-solid fa-pen""></i><span>Amazing Design to Present Your App</span><br>
                            <i class=""fa-solid fa-pen""></i><span>Amazing Design to Present Your App</span><br>
                            <i class=""fa-solid fa-pen""></i><span>Amazing Design to Present Your App</span>
                            <div class=""classbtn"">
                                <button>START EXSPRENING</button>
                            </div>
                        </div>
                        <div class=""col-md-6 clas");
                WriteLiteral("sheader2\">\n                            <img src=\"assets/img/sdf.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4536, "\"", 4542, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </header>\n    <div class=\"container\">\n        <main role=\"main\" class=\"pb-3\">\n            ");
#nullable restore
#line 79 "C:\Users\Lenovo\Desktop\onepage-main\onepage323223\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

    <section class=""footer"">
        <div class=""boxfooter"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""classtex"">
                        <h1>Download Awesome App Now</h1>
                    </div>
                    <div class="" classfooter"">
                        <button>
                            <div class=""col-md-6"">
                                <i class=""fa-brands fa-apple""></i>
                            </div>
                            <div class=""col-md-6"">
                                <h1>Dowlanding</h1>
                            </div>
                        </button>
                        <button>
                            <div class=""col-md-6"">
                                <i class=""fa-brands fa-windows""></i>

                            </div>
                            <div class=""col-md-6"">
                                <h1>Dowlanding</h1>
                            </div>
    ");
                WriteLiteral(@"                    </button>
                        <button>
                            <div class=""col-md-6"">
                                <i class=""fa-brands fa-windows""></i>

                            </div>
                            <div class=""col-md-6"">
                                <h1>Dowlanding</h1>
                            </div>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <script src=""https://unpkg.com/swiper/swiper-bundle.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <script src=""assets/js/stylejs.js""></script>
");
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
            WriteLiteral("\n</html>");
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
