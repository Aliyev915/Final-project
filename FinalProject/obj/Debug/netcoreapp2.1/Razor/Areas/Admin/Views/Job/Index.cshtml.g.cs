#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Job\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8e6a6610c0b1ffb8a7c2d17545d4954dc185514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Job_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Job/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Job/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Job_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8e6a6610c0b1ffb8a7c2d17545d4954dc185514", @"/Areas/Admin/Views/Job/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba1458bdad0f8a0fc414102b106dd014b34e4549", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Job_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Job\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 5597, true);
            WriteLiteral(@"
<div class=""right-side"">
    <h4>Manage Job</h4>
    <div class=""manage"">
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Job Title</th>
                    <th scope=""col"">Date</th>
                    <th scope=""col"">Applications</th>
                    <th scope=""col"">Status</th>
                    <th scope=""col"">Active</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">
                        <div class=""job"">
                            <div class=""job-info"">
                                <div class=""name"">
                                    <h4>Restaurant General Manager</h4>
                                </div>
                                <div class=""info"">
                                    <span><i class=""fas fa-briefcase""></i> Content Writer</span>
                                    <span><i class=""fas fa-map-marker-alt""></i> New");
            WriteLiteral(@" York City</span>
                                    <span><i class=""far fa-clock""></i>Full Time</span>
                                </div>
                            </div>
                        </div>
                    </th>
                    <td>Jan 31, 2019</td>
                    <td>5</td>
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
                <tr>
                    <th scope=""row"">
                        <div class=""job"">
                            <div class=""job-info"">
                                <div class=""name"">
                                    <h4>Green Development Marketer</h4>
                                </div>
                         ");
            WriteLiteral(@"       <div class=""info"">
                                    <span><i class=""fas fa-briefcase""></i> Content Writer</span>
                                    <span><i class=""fas fa-map-marker-alt""></i> New York City</span>
                                    <span><i class=""far fa-clock""></i>Full Time</span>
                                </div>
                            </div>
                        </div>
                    </th>
                    <td>Jan 31, 2019</td>
                    <td>7</td>
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
                <tr>
                    <th scope=""row"">
                        <div class=""job"">
                            <div c");
            WriteLiteral(@"lass=""job-info"">
                                <div class=""name"">
                                    <h4>Development Marketer</h4>
                                </div>
                                <div class=""info"">
                                    <span><i class=""fas fa-briefcase""></i> Content Writer</span>
                                    <span><i class=""fas fa-map-marker-alt""></i> New York City</span>
                                    <span><i class=""far fa-clock""></i>Full Time</span>
                                </div>
                            </div>
                        </div>
                    </th>
                    <td>Jan 25, 2019</td>
                    <td>9</td>
                    <td>Active</td>
                    <td>
                        <a href="""">
                            <i class=""fas fa-edit""></i>
                        </a>
                        <a href="""">
                            <i class=""fas fa-trash""></i>
               ");
            WriteLiteral(@"         </a>
                    </td>
                </tr>
                <tr>
                    <th scope=""row"">
                        <div class=""job"">
                            <div class=""job-info"">
                                <div class=""name"">
                                    <h4>Xero Development Marketer</h4>
                                </div>
                                <div class=""info"">
                                    <span><i class=""fas fa-briefcase""></i> Content Writer</span>
                                    <span><i class=""fas fa-map-marker-alt""></i> New York City</span>
                                    <span><i class=""far fa-clock""></i>Full Time</span>
                                </div>
                            </div>
                        </div>
                    </th>
                    <td>Jan 31, 2019</td>
                    <td>7</td>
                    <td>Active</td>
                    <td>
                        <a ");
            WriteLiteral(@"href="""">
                            <i class=""fas fa-edit""></i>
                        </a>
                        <a href="""">
                            <i class=""fas fa-trash""></i>
                        </a>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class=""copyright"">
        <p>© 2018 Theme Vessel. Trademarks and brands are the property of their respective owners.</p>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
