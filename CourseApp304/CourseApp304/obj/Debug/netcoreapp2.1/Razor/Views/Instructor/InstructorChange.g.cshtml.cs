#pragma checksum "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a15ba117652983427aef444cdfb4e060ba80d5a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_InstructorChange), @"mvc.1.0.view", @"/Views/Instructor/InstructorChange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/InstructorChange.cshtml", typeof(AspNetCore.Views_Instructor_InstructorChange))]
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
#line 1 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
using CourseApp304.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a15ba117652983427aef444cdfb4e060ba80d5a4", @"/Views/Instructor/InstructorChange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05888fb4810b008c0674f9671848efd142deb4be", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_InstructorChange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueTuple<Instructor,IEnumerable<Instructor>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
   int counter = 0;

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 1815, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f33109e9ad942879c77484911d896f7", async() => {
                BeginContext(148, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 184, "\"", 207, 1);
#line 6 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 192, Model.Item1.Id, 192, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(208, 10, true);
                WriteLiteral("/>\r\n    \r\n");
                EndContext();
#line 8 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
     foreach (var course in Model.Item1.Courses)
    {
    

#line default
#line hidden
                BeginContext(281, 28, true);
                WriteLiteral("        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 309, "\"", 336, 3);
                WriteAttributeValue("", 316, "Courses[", 316, 8, true);
#line 11 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 324, counter, 324, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 332, "].Id", 332, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 337, "\"", 355, 1);
#line 11 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 345, course.Id, 345, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(356, 34, true);
                WriteLiteral("  />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 390, "\"", 419, 3);
                WriteAttributeValue("", 397, "Courses[", 397, 8, true);
#line 12 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 405, counter, 405, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 413, "].Name", 413, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 420, "\"", 440, 1);
#line 12 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 428, course.Name, 428, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(441, 54, true);
                WriteLiteral(" class=\"form-control\" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 495, "\"", 525, 3);
                WriteAttributeValue("", 502, "Courses[", 502, 8, true);
#line 13 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 510, counter, 510, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 518, "].Price", 518, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 526, "\"", 547, 1);
#line 13 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 534, course.Price, 534, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(548, 54, true);
                WriteLiteral(" class=\"form-control\" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 602, "\"", 638, 3);
                WriteAttributeValue("", 609, "Courses[", 609, 8, true);
#line 14 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 617, counter, 617, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 625, "].Description", 625, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 639, "\"", 666, 1);
#line 14 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 647, course.Description, 647, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(667, 34, true);
                WriteLiteral("  />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 701, "\"", 734, 3);
                WriteAttributeValue("", 708, "Courses[", 708, 8, true);
#line 15 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 716, counter, 716, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 724, "].isActive", 724, 10, true);
                EndWriteAttribute();
                BeginContext(735, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(738, 64, false);
#line 15 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                                           Write(Html.Raw(course.isActive ? "value=\"true\"" : "value=\"false\""));

#line default
#line hidden
                EndContext();
                BeginContext(803, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
                BeginContext(818, 79, true);
                WriteLiteral("        <div class=\"row my-1\">\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(898, 11, false);
#line 19 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
           Write(course.Name);

#line default
#line hidden
                EndContext();
                BeginContext(909, 69, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                ");
                EndContext();
                BeginContext(979, 12, false);
#line 22 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
           Write(course.Price);

#line default
#line hidden
                EndContext();
                BeginContext(991, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col\">\r\n                <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1067, "\"", 1104, 3);
                WriteAttributeValue("", 1074, "Courses[", 1074, 8, true);
#line 25 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 1082, counter, 1082, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1090, "].InstructorId", 1090, 14, true);
                EndWriteAttribute();
                BeginContext(1105, 24, true);
                WriteLiteral(" class=\"form-control\">\r\n");
                EndContext();
#line 26 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                     foreach(Instructor i in Model.Item2)
                    {
                        if(course.Instructor==i)
                        {   

#line default
#line hidden
                BeginContext(1291, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1319, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8dd1e3476ea495893c3395a9e19bf5c", async() => {
                    BeginContext(1351, 6, false);
#line 30 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                                      Write(i.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                        WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1366, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1452, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1480, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7c22ee73fa749b7aed4d308ea5622bb", async() => {
                    BeginContext(1503, 6, false);
#line 34 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                                             Write(i.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                               WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1518, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 35 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1570, 63, true);
                WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 40 "C:\Users\Section1\Desktop\CourseApp304Elif\CourseApp304\CourseApp304\CourseApp304\Views\Instructor\InstructorChange.cshtml"
        
        { counter++; }
    }

#line default
#line hidden
                BeginContext(1674, 156, true);
                WriteLiteral("\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col text-center\">\r\n            <button class=\"btn btn-success\" type=\"submit\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(1830, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad457783571f444aaeee5239c94b400f", async() => {
                    BeginContext(1876, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1886, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValueTuple<Instructor,IEnumerable<Instructor>>> Html { get; private set; }
    }
}
#pragma warning restore 1591