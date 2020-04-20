#pragma checksum "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3f788100af4945a85e1c4b7f0f615ced1e2c935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f788100af4945a85e1c4b7f0f615ced1e2c935", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5bea9ab759c8394bfef8f2618f3c227856ba4d9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<ol class=""breadcrumb"">
    <li class=""breadcrumb-item""><a href=""index.html"">Home</a> <i class=""fa fa-angle-right""></i></li>
</ol>
<!--four-grids here-->
<div class=""four-grids"">
    <div class=""col-md-3 four-grid"">
        <div class=""four-agileits"">
            <div class=""icon"">
                <i class=""glyphicon glyphicon-user"" aria-hidden=""true""></i>
            </div>
            <div class=""four-text"">
                <h3>Users</h3>
                <h4> ");
#nullable restore
#line 18 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Home\Index.cshtml"
                Write(ViewBag.usersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

            </div>

        </div>
    </div>
    <div class=""col-md-3 four-grid"">
        <div class=""four-agileinfo"">
            <div class=""icon"">
                <i class=""glyphicon glyphicon-list-alt"" aria-hidden=""true""></i>
            </div>
            <div class=""four-text"">
                <h3>Requests</h3>
                <h4>");
#nullable restore
#line 31 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Home\Index.cshtml"
               Write(ViewBag.requestsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

            </div>

        </div>
    </div>
    <div class=""col-md-3 four-grid"">
        <div class=""four-w3ls"">
            <div class=""icon"">
                <i class=""glyphicon glyphicon-phone"" aria-hidden=""true""></i>
            </div>
            <div class=""four-text"">
                <h3>Calls</h3>
                <h4> ");
#nullable restore
#line 44 "C:\Users\Oluseyi Peter\source\repos\CallogApp\CallogApp\Areas\Admin\Views\Home\Index.cshtml"
                Write(ViewBag.callsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

            </div>

        </div>
    </div>
    <div class=""col-md-3 four-grid"">
        <div class=""four-wthree"">
            <div class=""icon"">
                <i class=""glyphicon glyphicon-briefcase"" aria-hidden=""true""></i>
            </div>
            <div class=""four-text"">
                <h3>Projects</h3>
                <h4>Coming Soon</h4>

            </div>

        </div>
    </div>
    <div class=""clearfix""></div>
</div>
<!--//four-grids here-->
<!--agileinfo-grap-->
<div class=""agileinfo-grap"">
    <div class=""agileits-box"">
        <header class=""agileits-box-header clearfix"">
            <h3>Pending Issue(s)</h3>
            <div class=""toolbar"">
                
            </div>
        </header>
        <div class=""agileits-box-body clearfix"">
            <div id=""hero-area""></div>
        </div>
    </div>
</div>
<!--//agileinfo-grap-->
<!--photoday-section-->


");
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
