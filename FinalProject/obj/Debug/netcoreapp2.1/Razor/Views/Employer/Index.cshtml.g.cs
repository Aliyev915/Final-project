#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbfa7e803ff8b1c17e47be6807f3661454330832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_Index), @"mvc.1.0.view", @"/Views/Employer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employer/Index.cshtml", typeof(AspNetCore.Views_Employer_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbfa7e803ff8b1c17e47be6807f3661454330832", @"/Views/Employer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6820e20a63b297ad98dfbe2628c8a2a6741d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Employer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Company>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "old", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("job"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/search.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
  
    ViewData["Title"] = "Employers";

#line default
#line hidden
            BeginContext(74, 38, true);
            WriteLiteral("\r\n<input type=\"hidden\" id=\"controller\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 112, "\"", 163, 1);
#line 6 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
WriteAttributeValue("", 120, ViewContext.RouteData.Values["Controller"], 120, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(164, 601, true);
            WriteLiteral(@" />
<!--employer listing start  -->
<div class=""job-search-listing"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-9"">
                <div class=""right-section"">
                    <div class=""d-flex sort-section"">
                        <div class=""col-6"">
                            <h6 style=""font-weight: bold; margin-top: 8px;"">Sort By:</h6>
                        </div>
                        <div class=""col-6"">
                            <select class=""form-control"" id=""sort"">
                                ");
            EndContext();
            BeginContext(765, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdd8b963f8e4644a2212a41331b1f3b", async() => {
                BeginContext(785, 6, true);
                WriteLiteral("newest");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(800, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(834, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e08dc9aa44c4bd6a5b1e17ebb59ffce", async() => {
                BeginContext(854, 6, true);
                WriteLiteral("oldest");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(869, 146, true);
            WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"employers\">\r\n");
            EndContext();
#line 25 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
                         foreach (Company item in Model)
                        {

#line default
#line hidden
            BeginContext(1100, 277, true);
            WriteLiteral(@"                            <div class=""employer"">
                                <div class=""row"">
                                    <div class=""col-lg-2 col-sm-3"">
                                        <div class=""image"">
                                            ");
            EndContext();
            BeginContext(1377, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "449db64b8de342f186030d311d702cdb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1387, "~/img/company-logo/", 1387, 19, true);
#line 31 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
AddHtmlAttributeValue("", 1406, item.Logo, 1406, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1428, 270, true);
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""col-lg-10 col-sm"">
                                        <div class=""name"">
                                            <h4>");
            EndContext();
            BeginContext(1699, 9, false);
#line 36 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1708, 262, true);
            WriteLiteral(@"</h4>
                                        </div>
                                        <div class=""about"">
                                            <span><i class=""fas fa-map-marker-alt""></i>Baku</span>
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1970, "\"", 2033, 1);
#line 40 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
WriteAttributeValue("", 1977, Url.Action("Detail","Employer" ,new {slug=@item.Slug }), 1977, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2034, 51, true);
            WriteLiteral(">\r\n                                                ");
            EndContext();
            BeginContext(2086, 52, false);
#line 41 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
                                           Write(item.Jobs.Where(j => j.CompanyId == item.Id).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2138, 278, true);
            WriteLiteral(@" Open Position
                                            </a>
                                        </div>
                                        <div class=""description"">
                                            <p>
                                                ");
            EndContext();
            BeginContext(2417, 10, false);
#line 46 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
                                           Write(item.About);

#line default
#line hidden
            EndContext();
            BeginContext(2427, 220, true);
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 52 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2674, 969, true);
            WriteLiteral(@"                        <div class=""pagination"">
                            <ul>
                                <li>
                                    <a href="""">Prev</a>
                                </li>
                                <li>
                                    <a href="""" class=""actived"">1</a>
                                </li>
                                <li>
                                    <a href="""">2</a>
                                </li>
                                <li>
                                    <a href="""">3</a>
                                </li>
                                <li>
                                    <a href="""">Next</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!--employer listing end  -->

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3660, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3666, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1409b3ada7486090a4311fdf8fadff", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3704, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
