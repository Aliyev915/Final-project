#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87151c58751ed4e51269fc701b5af0f3bcf94dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Candidate_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Candidate/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Candidate/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Candidate_Index))]
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
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.DAL;

#line default
#line hidden
#line 4 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87151c58751ed4e51269fc701b5af0f3bcf94dcc", @"/Areas/Admin/Views/Candidate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fbc412a9b80f975e64d958d20b3c68ffdd86e4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Candidate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Candidate>>
    {
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
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(72, 468, true);
            WriteLiteral(@"<div class=""right-side"">
    <h4>Manage Candidate</h4>
    <div class=""manage"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Candidate</th>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">Wiews</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">Active</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 19 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
                 foreach (Candidate candidate in Model)
                {

#line default
#line hidden
            BeginContext(616, 210, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">\r\n                            <div class=\"candidate\">\r\n                                <div class=\"image\">\r\n                                    ");
            EndContext();
            BeginContext(826, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1afae397fb614ea69fc1a15f04794c95", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 836, "~/img/avatar/", 836, 13, true);
#line 25 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
AddHtmlAttributeValue("", 849, candidate.Image, 849, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
AddHtmlAttributeValue("", 872, candidate.Image, 872, 16, false);

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
            BeginContext(890, 204, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"candidate-info\">\r\n                                    <div class=\"name\">\r\n                                        <h4>");
            EndContext();
            BeginContext(1095, 18, false);
#line 29 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
                                       Write(candidate.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 182, true);
            WriteLiteral("</h4>\r\n                                    </div>\r\n                                    <div class=\"info\">\r\n                                        <span><i class=\"fas fa-check\"></i> ");
            EndContext();
            BeginContext(1296, 20, false);
#line 32 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
                                                                      Write(candidate.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 93, true);
            WriteLiteral("</span>\r\n                                        <span><i class=\"fas fa-map-marker-alt\"></i> ");
            EndContext();
            BeginContext(1410, 23, false);
#line 33 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
                                                                               Write(candidate.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 646, true);
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </th>
                        <td>Jan 31, 2019</td>
                        <td>27</td>
                        <td>Active</td>
                        <td>
                            <a href="""">
                                <i class=""fas fa-edit""></i>
                            </a>
                            <a href="""">
                                <i class=""fas fa-trash""></i>
                            </a>
                        </td>
                    </tr>
");
            EndContext();
#line 50 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Candidate\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2098, 205, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"copyright\">\r\n        <p>© 2018 Theme Vessel. Trademarks and brands are the property of their respective owners.</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Candidate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
