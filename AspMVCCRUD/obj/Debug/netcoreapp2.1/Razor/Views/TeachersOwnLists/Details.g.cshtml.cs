#pragma checksum "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb87bff981b342b9455799a92ae11f67003d5d9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeachersOwnLists_Details), @"mvc.1.0.view", @"/Views/TeachersOwnLists/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TeachersOwnLists/Details.cshtml", typeof(AspNetCore.Views_TeachersOwnLists_Details))]
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
#line 1 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\_ViewImports.cshtml"
using AspMVCCRUD;

#line default
#line hidden
#line 2 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\_ViewImports.cshtml"
using AspMVCCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb87bff981b342b9455799a92ae11f67003d5d9a", @"/Views/TeachersOwnLists/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc498ea49351ffdad11c3be5a41e1674e7b618ff", @"/Views/_ViewImports.cshtml")]
    public class Views_TeachersOwnLists_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspMVCCRUD.Models.TeachersOwnList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 129, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>TeachersOwnList</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(217, 44, false);
#line 14 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.courseId));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 40, false);
#line 17 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.courseId));

#line default
#line hidden
            EndContext();
            BeginContext(345, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(389, 50, false);
#line 20 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.completeCourse));

#line default
#line hidden
            EndContext();
            BeginContext(439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(483, 46, false);
#line 23 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.completeCourse));

#line default
#line hidden
            EndContext();
            BeginContext(529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(573, 51, false);
#line 26 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PointPerCourses));

#line default
#line hidden
            EndContext();
            BeginContext(624, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(668, 47, false);
#line 29 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.PointPerCourses));

#line default
#line hidden
            EndContext();
            BeginContext(715, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(759, 59, false);
#line 32 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberofClassPerCourses));

#line default
#line hidden
            EndContext();
            BeginContext(818, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(862, 55, false);
#line 35 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberofClassPerCourses));

#line default
#line hidden
            EndContext();
            BeginContext(917, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(961, 63, false);
#line 38 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberofDoneClassPerCourses));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1068, 59, false);
#line 41 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberofDoneClassPerCourses));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1171, 49, false);
#line 44 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PickUpAmmount));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1264, 45, false);
#line 47 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
       Write(Html.DisplayFor(model => model.PickUpAmmount));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1356, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "784fe9e4cea04db5ae3692c6b0d102eb", async() => {
                BeginContext(1417, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\ASUS\OneDrive\Desktop\Hackathon\AspMVCCRUD\Views\TeachersOwnLists\Details.cshtml"
                           WriteLiteral(Model.TeachersOwnListId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1425, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1433, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daf324d3e4a243699235aad5bebc1dad", async() => {
                BeginContext(1455, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1471, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspMVCCRUD.Models.TeachersOwnList> Html { get; private set; }
    }
}
#pragma warning restore 1591