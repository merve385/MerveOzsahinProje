#pragma checksum "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c69e97ca4f633a2f146fbc86db2a37685354bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304;

#line default
#line hidden
#line 2 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\_ViewImports.cshtml"
using CourseApp304.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c69e97ca4f633a2f146fbc86db2a37685354bbf", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05888fb4810b008c0674f9671848efd142deb4be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseApp304.Models.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(89, 484, true);
            WriteLiteral(@"
<div class=""m-5"">
    <div class=""bg-danger text-white p-4"">
        Request List
    </div>

    <div class=""table-responsive"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Message</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(638, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(693, 7, false);
#line 26 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(700, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(736, 9, false);
#line 27 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(745, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(781, 10, false);
#line 28 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(791, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(827, 10, false);
#line 29 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(837, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(873, 12, false);
#line 30 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                       Write(item.Message);

#line default
#line hidden
            EndContext();
            BeginContext(885, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 32 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Home\List.cshtml"
                }

#line default
#line hidden
            BeginContext(938, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseApp304.Models.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
