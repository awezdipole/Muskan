#pragma checksum "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffb6e655a1139b22c42f95d7347680eb1ba04675"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Details), @"mvc.1.0.view", @"/Views/Bills/Details.cshtml")]
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
#nullable restore
#line 1 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\_ViewImports.cshtml"
using MuskanChildrenHospitalApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\_ViewImports.cshtml"
using MuskanChildrenHospitalApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb6e655a1139b22c42f95d7347680eb1ba04675", @"/Views/Bills/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10d8960607bc944410b6726816a8d1bff348432", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MuskanChildrenHospitalApp.Models.Bill>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Bill</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BillNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.BillNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateOfDischarge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateOfDischarge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diagnosis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diagnosis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Advance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Advance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AmountInWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.AmountInWords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Addmision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Addmision.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Refund));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
       Write(Html.DisplayFor(model => model.Refund));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffb6e655a1139b22c42f95d7347680eb1ba0467511103", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 77 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\Bills\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffb6e655a1139b22c42f95d7347680eb1ba0467513267", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MuskanChildrenHospitalApp.Models.Bill> Html { get; private set; }
    }
}
#pragma warning restore 1591
