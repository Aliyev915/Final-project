#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf1cd56a6e22e3611b967a0ec223af2b6ab2d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employer_Detail), @"mvc.1.0.view", @"/Views/Employer/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employer/Detail.cshtml", typeof(AspNetCore.Views_Employer_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf1cd56a6e22e3611b967a0ec223af2b6ab2d31", @"/Views/Employer/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea6820e20a63b297ad98dfbe2628c8a2a6741d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Employer_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Company>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-apply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(58, 435, true);
            WriteLiteral(@"
<!--candidate detail start  -->
<div class=""employer-detail"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""left-section"">
                    <div class=""employer-feature"">
                        <div class=""row"">
                            <div class=""col-2"">
                                <div class=""image"">
                                    ");
            EndContext();
            BeginContext(493, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adf665e313d942aa8fb802297141123b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 503, "~/img/company-logo/", 503, 19, true);
#line 16 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
AddHtmlAttributeValue("", 522, Model.Logo, 522, 11, false);

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
            BeginContext(542, 276, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-10"">
                                <div class=""info"">
                                    <div class=""name"">
                                        ");
            EndContext();
            BeginContext(819, 10, false);
#line 22 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(829, 125, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <span><i class=\"fas fa-map-marker-alt\"></i>");
            EndContext();
            BeginContext(955, 12, false);
#line 24 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                                                          Write(Model.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(967, 295, true);
            WriteLiteral(@"</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""employer-about"">
                        <h3>About Me</h3>
                        <p>
                            ");
            EndContext();
            BeginContext(1263, 11, false);
#line 32 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                       Write(Model.About);

#line default
#line hidden
            EndContext();
            BeginContext(1274, 202, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"related-job\">\r\n                        <h3>Related Jobs</h3>\r\n                        <div class=\"job-list\">\r\n");
            EndContext();
#line 38 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                             foreach (Job item in ViewBag.Jobs)
                            {

#line default
#line hidden
            BeginContext(1572, 305, true);
            WriteLiteral(@"                                <div class=""job-about"">
                                    <div class=""row"">
                                        <div class=""col-lg-2 col-sm-4"">
                                            <div class=""company-logo"">
                                                ");
            EndContext();
            BeginContext(1877, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "340b49d791184e4daee551c271259d9c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1887, "~/img/company-logo/", 1887, 19, true);
#line 44 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
AddHtmlAttributeValue("", 1906, item.Company.Logo, 1906, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1937, 289, true);
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-lg-6 col-sm"">
                                            <div class=""name"">
                                                <h5>");
            EndContext();
            BeginContext(2227, 9, false);
#line 49 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2236, 281, true);
            WriteLiteral(@"</h5>
                                            </div>
                                            <div class=""add-info"">
                                                <div class=""row"">
                                                    <p><i class=""fas fa-briefcase""></i>");
            EndContext();
            BeginContext(2518, 18, false);
#line 53 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                                                                  Write(item.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2536, 98, true);
            WriteLiteral("</p>\r\n                                                    <p><i class=\"fas fa-map-marker-alt\"></i>");
            EndContext();
            BeginContext(2635, 18, false);
#line 54 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                                                                       Write(item.Location.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2653, 396, true);
            WriteLiteral(@"</p>
                                                    <p><i class=""far fa-clock""></i> Full Time</p>
                                                </div>
                                            </div>
                                            <div class=""deadline"">
                                                <p>Deadline: 
                                                    ");
            EndContext();
            BeginContext(3050, 45, false);
#line 60 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                               Write(item.Deadline.ToString("MMMM").Substring(0,3));

#line default
#line hidden
            EndContext();
            BeginContext(3095, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3097, 17, false);
#line 60 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                                                                              Write(item.Deadline.Day);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(3117, 18, false);
#line 60 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                                                                                                  Write(item.Deadline.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3135, 662, true);
            WriteLiteral(@"                                                
                                                </p>
                                            </div>
                                        </div>
                                        <div class=""col-lg-4"">
                                            <div class=""row"">
                                                <div class=""favorite"">
                                                    <i class=""far fa-heart""></i>
                                                </div>
                                                <div class=""apply"">
                                                    ");
            EndContext();
            BeginContext(3797, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5439cfd7b3c429cac6e0d65c4d4fc5c", async() => {
                BeginContext(3883, 121, true);
                WriteLiteral("\r\n                                                        Apply Now\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4008, 242, true);
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 78 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(4281, 314, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""right-section"">
                    <div class=""download"">
                        <button class=""btn-download"">
                            ");
            EndContext();
            BeginContext(4596, 54, false);
#line 88 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                       Write(Model.Jobs.Where(j => j.CompanyId == Model.Id).Count());

#line default
#line hidden
            EndContext();
            BeginContext(4650, 1266, true);
            WriteLiteral(@" open positions
                        </button>
                    </div>
                    <div class=""save"">
                        <button class=""btn-save"">
                            save
                        </button>
                    </div>
                    <div class=""search-side"">
                        <div class=""overview"">
                            <h3>Job Overview</h3>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""fas fa-eye""></i>
                                </div>
                                <div class=""col-9"">
                                    <h5 style=""font-weight: bold;"">Viewed</h5>
                                    <p>25470</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""f");
            WriteLiteral("ar fa-address-card\"></i>\r\n                                </div>\r\n                                <div class=\"col-9\">\r\n                                    <h5 style=\"font-weight: bold;\">Posted Job</h5>\r\n                                    <p>");
            EndContext();
            BeginContext(5917, 54, false);
#line 114 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                  Write(Model.Jobs.Where(j => j.CompanyId == Model.Id).Count());

#line default
#line hidden
            EndContext();
            BeginContext(5971, 471, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""fas fa-map-marker-alt""></i>
                                </div>
                                <div class=""col-9"">
                                    <h5 style=""font-weight: bold;"">Location</h5>
                                    <p>");
            EndContext();
            BeginContext(6443, 12, false);
#line 123 "C:\Users\Code\Desktop\FinalProject\FinalProject\Views\Employer\Detail.cshtml"
                                  Write(Model.Adress);

#line default
#line hidden
            EndContext();
            BeginContext(6455, 711, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-3"">
                                    <i class=""far fa-user""></i>
                                </div>
                                <div class=""col-9"">
                                    <h5 style=""font-weight: bold;"">Followers</h5>
                                    <p>14</p>
                                </div>
                            </div>
                        </div>
                        <div class=""quick-contact"">
                            <h3>Quick Contact</h3>
                            ");
            EndContext();
            BeginContext(7166, 369, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4aeb918920541149a0275125d749bf0", async() => {
                BeginContext(7182, 346, true);
                WriteLiteral(@"
                                <input type=""text"" placeholder=""Name"">
                                <input type=""text"" placeholder=""Name"">
                                <textarea rows=""5"" placeholder=""Write message""></textarea>
                                <button class=""btn-send"">Send Message</button>
                            ");
                EndContext();
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
            EndContext();
            BeginContext(7535, 173, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--candidate detail end  -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
