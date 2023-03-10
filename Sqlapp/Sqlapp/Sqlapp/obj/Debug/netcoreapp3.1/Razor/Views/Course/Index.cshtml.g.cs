#pragma checksum "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06e9ed4caf5c4de0814c645d931bb3d4ee39b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06e9ed4caf5c4de0814c645d931bb3d4ee39b7a", @"/Views/Course/Index.cshtml")]
    #nullable restore
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sqlapp.Models.Course>>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b06e9ed4caf5c4de0814c645d931bb3d4ee39b7a2795", async() => {
                WriteLiteral("\r\n\r\n\r\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\r\n");
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
            WriteLiteral(@"

<div class=""text-center"">
    <h1 class=""display-4"">This is a list of courses</h1>

</div>

<div>
    <table class=""table"" table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Course ID</th>
                <th scope=""col"">For exam</th>
                <th scope=""col"">Course Name</th>
                <th scope=""col"">Rating</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
             foreach (var course in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 30 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
                           Write(course.CourseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\"><img");
            BeginWriteAttribute("src", " src=\"", 917, "\"", 940, 1);
#nullable restore
#line 31 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
WriteAttributeValue("", 923, course.ExamImage, 923, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"100\"></th>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
               Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
               Write(course.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\003R5B744\Desktop\DE\Azure\Sqlapp\Sqlapp\Sqlapp\Views\Course\Index.cshtml"
            }            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sqlapp.Models.Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
