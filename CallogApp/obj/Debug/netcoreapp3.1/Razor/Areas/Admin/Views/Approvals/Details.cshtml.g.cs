#pragma checksum "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ce4e9ae4d24f70d486204c24077299d5c935fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Approvals_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Approvals/Details.cshtml")]
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
#line 1 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\_ViewImports.cshtml"
using CallogApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\_ViewImports.cshtml"
using CallogApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ce4e9ae4d24f70d486204c24077299d5c935fa", @"/Areas/Admin/Views/Approvals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5bea9ab759c8394bfef8f2618f3c227856ba4d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Approvals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CallogApp.Models.Approval>
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
#line 3 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Approval</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 24 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 27 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Requester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Requester.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentMode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentMode.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 39 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Currency.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 45 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LeagerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 48 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.LeagerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 51 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AnnualBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 54 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.AnnualBudget));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 57 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YTD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 60 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.YTD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 63 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 69 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.YTDPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 72 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.YTDPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 75 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Beneficiary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 78 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Beneficiary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 81 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.JobDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 84 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.JobDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 87 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 90 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 93 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 96 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 99 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdvanceRequired));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 102 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdvanceRequired));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 105 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PreparedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 108 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.PreparedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 111 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 114 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 117 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AuthorisedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 120 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.AuthorisedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 123 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApprovedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 126 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApprovedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 129 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 132 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 135 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApprovalLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 138 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApprovalLevel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 141 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ApprovedStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 144 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
       Write(Html.DisplayFor(model => model.ApprovedStatus.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54ce4e9ae4d24f70d486204c24077299d5c935fa18442", async() => {
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
#line 149 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Approvals\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54ce4e9ae4d24f70d486204c24077299d5c935fa20605", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CallogApp.Models.Approval> Html { get; private set; }
    }
}
#pragma warning restore 1591
