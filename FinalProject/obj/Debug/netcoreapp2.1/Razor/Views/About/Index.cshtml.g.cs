#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7c0926a359af36ae012b5f16807b1f8d528a1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 1 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7c0926a359af36ae012b5f16807b1f8d528a1e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6820e20a63b297ad98dfbe2628c8a2a6741d30", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
            BeginContext(60, 437, true);
            WriteLiteral(@"

<!-- categories end -->
<div class=""categories"">
    <div class=""container"">
        <div class=""content"">
            <div class=""title"">
                <h2>Popular Categories</h2>
            </div>
            <div class=""description"">
                <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit.</p>
            </div>
        </div>
        <div class=""job-category"">
            <div class=""row"">
");
            EndContext();
#line 20 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                 foreach (Category item in Model.Categories)
                {

#line default
#line hidden
            BeginContext(578, 134, true);
            WriteLiteral("                    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                        <div class=\"icon\">\r\n                            ");
            EndContext();
            BeginContext(713, 19, false);
#line 24 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                       Write(Html.Raw(item.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(732, 106, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"name\">\r\n                            ");
            EndContext();
            BeginContext(839, 9, false);
#line 27 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(848, 108, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"count\">\r\n                            (");
            EndContext();
            BeginContext(957, 15, false);
#line 30 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                        Write(item.Jobs.Count);

#line default
#line hidden
            EndContext();
            BeginContext(972, 63, true);
            WriteLiteral(")\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 33 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1054, 436, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- categories end -->
<!-- Our Services start -->
<div class=""service-area"">
    <div class=""container"">
        <div class=""title"">
            <h2>Our Service</h2>
        </div>
        <div class=""description"">
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
        </div>
        <div class=""service"">
            <div class=""row"">
");
            EndContext();
#line 50 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                 foreach (Service item in Model.Services)
                {

#line default
#line hidden
            BeginContext(1568, 183, true);
            WriteLiteral("                    <div class=\"col-lg-4\">\r\n                        <div class=\"service-box\">\r\n                            <div class=\"service-icon\">\r\n                                ");
            EndContext();
            BeginContext(1752, 19, false);
#line 55 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                           Write(Html.Raw(item.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 131, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"service-title\">\r\n                                <h3>");
            EndContext();
            BeginContext(1903, 10, false);
#line 58 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1913, 134, true);
            WriteLiteral("</h3>\r\n                            </div>\r\n                            <div class=\"service-text\">\r\n                                <p>");
            EndContext();
            BeginContext(2048, 16, false);
#line 61 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2064, 102, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 65 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2185, 236, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Our Services end -->\r\n\r\n<!-- statistics start -->\r\n<div class=\"statistics\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center align-items-center\">\r\n");
            EndContext();
#line 76 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
             foreach (Statistic item in Model.Statistics)
            {

#line default
#line hidden
            BeginContext(2495, 117, true);
            WriteLiteral("                <div class=\"col-lg-3 col-md-6\">\r\n\r\n                    <div class=\"member\">\r\n                        ");
            EndContext();
            BeginContext(2613, 19, false);
#line 81 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                   Write(Html.Raw(item.Icon));

#line default
#line hidden
            EndContext();
            BeginContext(2632, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                         if (item.Title == "Members")
                        {

#line default
#line hidden
            BeginContext(2716, 68, true);
            WriteLiteral("                            <h1 class=\"counter text-white\" data-to=\"");
            EndContext();
            BeginContext(2785, 17, false);
#line 84 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                               Write(ViewBag.UserCount);

#line default
#line hidden
            EndContext();
            BeginContext(2802, 9, true);
            WriteLiteral("\"></h1>\r\n");
            EndContext();
#line 85 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2838, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 86 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                         if (item.Title == "Jobs")
                        {

#line default
#line hidden
            BeginContext(2917, 68, true);
            WriteLiteral("                            <h1 class=\"counter text-white\" data-to=\"");
            EndContext();
            BeginContext(2986, 16, false);
#line 88 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                               Write(ViewBag.JobCount);

#line default
#line hidden
            EndContext();
            BeginContext(3002, 9, true);
            WriteLiteral("\"></h1>\r\n");
            EndContext();
#line 89 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3038, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 90 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                         if (item.Title == "Resumes")
                        {

#line default
#line hidden
            BeginContext(3120, 68, true);
            WriteLiteral("                            <h1 class=\"counter text-white\" data-to=\"");
            EndContext();
            BeginContext(3189, 19, false);
#line 92 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                               Write(ViewBag.ResumeCount);

#line default
#line hidden
            EndContext();
            BeginContext(3208, 9, true);
            WriteLiteral("\"></h1>\r\n");
            EndContext();
#line 93 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3244, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 94 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                         if (item.Title == "Companies")
                        {

#line default
#line hidden
            BeginContext(3328, 68, true);
            WriteLiteral("                            <h1 class=\"counter text-white\" data-to=\"");
            EndContext();
            BeginContext(3397, 20, false);
#line 96 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                                                               Write(ViewBag.CompanyCount);

#line default
#line hidden
            EndContext();
            BeginContext(3417, 9, true);
            WriteLiteral("\"></h1>\r\n");
            EndContext();
#line 97 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3453, 46, true);
            WriteLiteral("                        <p class=\"text-white\">");
            EndContext();
            BeginContext(3500, 10, false);
#line 98 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
                                         Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3510, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 101 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3583, 494, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- statistics end -->

<!-- partnership companies start -->
<div class=""partnership-company"">
    <div class=""container"">
        <div class=""content"">
            <div class=""title"">
                <h2>Companies We've Helped</h2>
            </div>
            <div class=""description"">
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
            </div>
        </div>
        <div class=""row owl-carousel"">
");
            EndContext();
#line 119 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
             foreach (Company item in Model.Companies)
            {

#line default
#line hidden
            BeginContext(4148, 57, true);
            WriteLiteral("                <div class=\"brand\">\r\n                    ");
            EndContext();
            BeginContext(4205, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf135bb348cc48f38a6b1500a7dd3fa1", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4215, "~/img/company-logo/", 4215, 19, true);
#line 122 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 4234, item.Logo, 4234, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4253, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 124 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\About\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4294, 72, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- partnership companies end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
