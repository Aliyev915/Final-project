#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08a8ba66c374c128655cee3692ac4eca6aeea7e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Left_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Left/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Left/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Left_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08a8ba66c374c128655cee3692ac4eca6aeea7e0", @"/Views/Shared/Components/Left/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6820e20a63b297ad98dfbe2628c8a2a6741d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Left_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComponentVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(47, 76, true);
            WriteLiteral("    <div class=\"col-lg-4\">\r\n        <div class=\"left-section\">\r\n            ");
            EndContext();
            BeginContext(123, 7402, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b785a36374b46e79f3d36f49fd40f99", async() => {
                BeginContext(139, 545, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label>Keywords</label>
                    <input type=""text"" placeholder=""Search Keywords"" class=""form-control"">
                </div>
                <div class=""form-group"" style=""position: relative;"">
                    <label>Location</label>
                    <input type=""text"" placeholder=""All Location"" readonly class=""form-control"">
                    <div class=""selectList"">
                        <ul>
                            <li>All Location</li>
");
                EndContext();
#line 18 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
                             foreach (Location item in Model.Locations)
                            {

#line default
#line hidden
                BeginContext(788, 36, true);
                WriteLiteral("                                <li>");
                EndContext();
                BeginContext(825, 9, false);
#line 20 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(834, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 21 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
                            }

#line default
#line hidden
                BeginContext(872, 558, true);
                WriteLiteral(@"                        </ul>

                    </div>
                    <div class=""down"">
                        <i class=""fas fa-caret-down""></i>
                    </div>
                </div>
                <div class=""form-group"" style=""position: relative;"">
                    <label>Categories</label>
                    <input type=""text"" placeholder=""All Categories"" readonly class=""form-control"">
                    <div class=""selectList"">
                        <ul>
                            <li>All Categories</li>
");
                EndContext();
#line 35 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
                             foreach (Category item in Model.Categories)
                            {

#line default
#line hidden
                BeginContext(1535, 36, true);
                WriteLiteral("                                <li>");
                EndContext();
                BeginContext(1572, 9, false);
#line 37 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1581, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 38 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Shared\Components\Left\Default.cshtml"
                            }

#line default
#line hidden
                BeginContext(1619, 5899, true);
                WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""down"">
                        <i class=""fas fa-caret-down""></i>
                    </div>
                </div>
                <div class=""radio-button-section"">
                    <div class=""radio-buttons"">
                        <div class=""row job-features"">
                            <div class=""icon"">
                                <i class=""fas fa-plus""></i>
                            </div>
                            <p>Job Type</p>
                        </div>
                        <div class=""job-selection"">
                            <input type=""radio"" name=""jobType"" value=""full-time"">
                            <label>Full Time</label><br>
                            <input type=""radio"" name=""jobType"" value=""part-time"">
                            <label>Part Time</label><br>
                        </div>
                    </div>
                    <div class=""radio-bu");
                WriteLiteral(@"ttons"">
                        <div class=""row job-features"">
                            <div class=""icon"">
                                <i class=""fas fa-plus""></i>
                            </div>
                            <p>Data Posted</p>
                        </div>
                        <div class=""job-selection"">
                            <input type=""radio"" name=""DataPosted"" value=""last-hour"">
                            <label>Last Hour</label><br>
                            <input type=""radio"" name=""DataPosted"" value=""last-24-hour"">
                            <label>Last 24 Hour</label><br>
                            <input type=""radio"" name=""DataPosted"" value=""last-7-days"">
                            <label>Last 7 Days</label><br>
                            <input type=""radio"" name=""DataPosted"" value=""last-30-days"">
                            <label>Last 30 Days</label><br>
                        </div>
                    </div>
                    <div clas");
                WriteLiteral(@"s=""radio-buttons"">
                        <div class=""row job-features"">
                            <div class=""icon"">
                                <i class=""fas fa-plus""></i>
                            </div>
                            <p>Experince</p>
                        </div>
                        <div class=""job-selection"">
                            <input type=""radio"" name=""Experince"" value=""0-1 year"">
                            <label>0-1 Year</label><br>
                            <input type=""radio"" name=""Experince"" value=""1-3 years"">
                            <label>1-3 Years</label><br>
                            <input type=""radio"" name=""Experince"" value=""3-5 years"">
                            <label>3-5 Years</label><br>
                            <input type=""radio"" name=""Experince"" value=""more 5 years"">
                            <label>More 5 Years</label><br>
                        </div>
                    </div>
                    <div class=""radi");
                WriteLiteral(@"o-buttons"">
                        <div class=""row job-features"">
                            <div class=""icon"">
                                <i class=""fas fa-plus""></i>
                            </div>
                            <p>Offered Salary</p>
                        </div>
                        <div class=""job-selection"">
                            <input type=""radio"" name=""Salary"" value=""0-300"">
                            <label>0-300</label><br>
                            <input type=""radio"" name=""Salary"" value=""300-600"">
                            <label>300-600</label><br>
                            <input type=""radio"" name=""Salary"" value=""600-1000"">
                            <label>600-1000</label><br>
                            <input type=""radio"" name=""Salary"" value=""1000+"">
                            <label>1000+</label><br>
                        </div>
                    </div>
                    <div class=""radio-buttons"">
                        <di");
                WriteLiteral(@"v class=""row job-features"">
                            <div class=""icon"">
                                <i class=""fas fa-plus""></i>
                            </div>
                            <p>Education</p>
                        </div>
                        <div class=""job-selection"">
                            <input type=""radio"" name=""Education"" value=""Secondary"">
                            <label>Secondary</label><br>
                            <input type=""radio"" name=""Education"" value=""Subbachelor"">
                            <label>Subbachelor</label><br>
                            <input type=""radio"" name=""Education"" value=""Bachelor"">
                            <label>Bachelor</label><br>
                            <input type=""radio"" name=""Education"" value=""Master"">
                            <label>Master</label><br>
                        </div>
                    </div>
                    <div class=""radio-buttons"">
                        <div class=""row jo");
                WriteLiteral(@"b-features"">
                            <div class=""icon"">
                                <i class=""fas fa-plus""></i>
                            </div>
                            <p>Gender</p>
                        </div>
                        <div class=""job-selection"">
                            <input type=""radio"" name=""Gender"" value=""Male"">
                            <label>Male</label><br>
                            <input type=""radio"" name=""Gender"" value=""Female"">
                            <label>Female</label><br>
                            <input type=""radio"" name=""Gender"" value=""Other"">
                            <label>Other</label><br>
                        </div>
                    </div>
                </div>
            ");
                EndContext();
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
            EndContext();
            BeginContext(7525, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComponentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
