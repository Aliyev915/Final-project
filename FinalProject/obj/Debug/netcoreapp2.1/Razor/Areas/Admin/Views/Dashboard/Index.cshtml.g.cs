#pragma checksum "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4fddd57ebe20d89fdf0a27483df80ba82c20c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4fddd57ebe20d89fdf0a27483df80ba82c20c9", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fbc412a9b80f975e64d958d20b3c68ffdd86e4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 323, true);
            WriteLiteral(@"
    <div class=""right-side"">
        <h4>Hello, Sadig Aliyev</h4>
        <div class=""statistic"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""listing bg-success"">
                        <div class=""count"">
                            <h4>");
            EndContext();
            BeginContext(394, 13, false);
#line 13 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(ViewBag.Users);

#line default
#line hidden
            EndContext();
            BeginContext(407, 462, true);
            WriteLiteral(@"</h4>
                            <p>Users</p>
                        </div>
                        <div class=""icon"">
                            <i class=""fas fa-map-marker-alt""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""view bg-warning"">
                        <div class=""count"">
                            <h4>");
            EndContext();
            BeginContext(870, 12, false);
#line 24 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(ViewBag.Jobs);

#line default
#line hidden
            EndContext();
            BeginContext(882, 452, true);
            WriteLiteral(@"</h4>
                            <p>Jobs</p>
                        </div>
                        <div class=""icon"">
                            <i class=""fas fa-eye""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""review bg-primary"">
                        <div class=""count"">
                            <h4>");
            EndContext();
            BeginContext(1335, 18, false);
#line 35 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(ViewBag.Candidates);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 462, true);
            WriteLiteral(@"</h4>
                            <p>Candidates</p>
                        </div>
                        <div class=""icon"">
                            <i class=""far fa-comments""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6"">
                    <div class=""bookmark bg-dark"">
                        <div class=""count"">
                            <h4>");
            EndContext();
            BeginContext(1816, 17, false);
#line 46 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(ViewBag.Bookmarks);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 1012, true);
            WriteLiteral(@"</h4>
                            <p>Bookmarked</p>
                        </div>
                        <div class=""icon"">
                            <i class=""far fa-heart""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""user-account"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""users"">
                        <div class=""user-nav"">
                            <div class=""row justify-content-between"">
                                <h5>New Users</h5>
                                <div class=""time"">
                                    <span class=""actived"" data-id=""today"">Today</span>
                                    <span data-id=""month"">Month</span>
                                </div>
                            </div>
                        </div>
                        <div class=""userList"" data-id=""today"">
");
            EndContext();
#line 70 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                             foreach (AppUser item in Model.Where(u=>u.RegisterDate.Day==DateTime.Today.Day))
                            {

#line default
#line hidden
            BeginContext(2987, 222, true);
            WriteLiteral("                                <div class=\"row mb-4\">\r\n                                    <div class=\"col-2\">\r\n                                        <div class=\"image\">\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3209, "\"", 3233, 2);
            WriteAttributeValue("", 3215, "../img/", 3215, 7, true);
#line 75 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 3222, item.Image, 3222, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3234, 272, true);
            WriteLiteral(@" alt="""">
                                        </div>
                                    </div>
                                    <div class=""col-6"">
                                        <div class=""user-info"">
                                            <h5>");
            EndContext();
            BeginContext(3507, 13, false);
#line 80 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(item.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(3520, 57, true);
            WriteLiteral("</h5>\r\n                                            <span>");
            EndContext();
            BeginContext(3578, 10, false);
#line 81 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                                             Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3588, 141, true);
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 85 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3760, 105, true);
            WriteLiteral("                        </div>\r\n                        <div class=\"userList d-none\" data-id=\"month\">\r\n\r\n");
            EndContext();
#line 89 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                             foreach (AppUser item in Model.Where(u => u.RegisterDate.Month == DateTime.Today.Month))
                            {

#line default
#line hidden
            BeginContext(4015, 222, true);
            WriteLiteral("                                <div class=\"row mb-4\">\r\n                                    <div class=\"col-2\">\r\n                                        <div class=\"image\">\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4237, "\"", 4261, 2);
            WriteAttributeValue("", 4243, "../img/", 4243, 7, true);
#line 94 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 4250, item.Image, 4250, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4262, 272, true);
            WriteLiteral(@" alt="""">
                                        </div>
                                    </div>
                                    <div class=""col-6"">
                                        <div class=""user-info"">
                                            <h5>");
            EndContext();
            BeginContext(4535, 13, false);
#line 99 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(item.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(4548, 57, true);
            WriteLiteral("</h5>\r\n                                            <span>");
            EndContext();
            BeginContext(4606, 10, false);
#line 100 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                                             Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(4616, 141, true);
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 104 "C:\Users\Code\Desktop\FinalProject\FinalProject\Areas\Admin\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4788, 289, true);
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
