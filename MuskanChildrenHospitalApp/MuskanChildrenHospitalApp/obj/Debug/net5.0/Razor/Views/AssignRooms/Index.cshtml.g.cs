#pragma checksum "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82695bbb702cff8d09500543c574ee2dcdd1181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AssignRooms_Index), @"mvc.1.0.view", @"/Views/AssignRooms/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e82695bbb702cff8d09500543c574ee2dcdd1181", @"/Views/AssignRooms/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10d8960607bc944410b6726816a8d1bff348432", @"/Views/_ViewImports.cshtml")]
    public class Views_AssignRooms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MuskanChildrenHospitalApp.Models.Addmision>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
  
    ViewData["Title"] = "Transfer Paitent";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <div class=""card-header"">
        <div class=""row"">
            <div class=""col-md-6""><h2>Addmissions List</h2></div>
            <div class=""col-md-6"">
               
            </div>
        </div>


    </div>
    <!-- /.card-header -->
    <div class=""card-body"">
        <table id=""example1"" class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 26 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DateOfAdmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DateOfDischarge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsDischarge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 51 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RegistrationNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RoomName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateOfAdmission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateOfDischarge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.IsDischarge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82695bbb702cff8d09500543c574ee2dcdd11819439", async() => {
                WriteLiteral("Change Room");
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
#line 75 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                                                     WriteLiteral(item.id);

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
            WriteLiteral(" |\r\n                           \r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 79 "F:\Work\muskan\Muskan\MuskanChildrenHospitalApp\MuskanChildrenHospitalApp\Views\AssignRooms\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <!-- /.card-body -->
</div>



<!-- page script -->
<script>
    $(function () {
        $(""#example1"").DataTable();
        $('#example2').DataTable({
            ""paging"": true,
            ""lengthChange"": false,
            ""searching"": false,
            ""ordering"": true,
            ""info"": true,
            ""autoWidth"": false,
        });
    });</script>
<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e82695bbb702cff8d09500543c574ee2dcdd118112425", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MuskanChildrenHospitalApp.Models.Addmision>> Html { get; private set; }
    }
}
#pragma warning restore 1591
