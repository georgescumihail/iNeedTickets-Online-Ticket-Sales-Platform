#pragma checksum "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b355d08d1cd00ef3268a7c929d658bfcdb83de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manager_ManagerMenu), @"mvc.1.0.view", @"/Areas/Admin/Views/Manager/ManagerMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manager/ManagerMenu.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manager_ManagerMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b355d08d1cd00ef3268a7c929d658bfcdb83de", @"/Areas/Admin/Views/Manager/ManagerMenu.cshtml")]
    public class Areas_Admin_Views_Manager_ManagerMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<iNeedTickets.Models.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/manager-menu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/manager.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
  
    ViewData["Title"] = "ManagerMenu";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(146, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b355d08d1cd00ef3268a7c929d658bfcdb83de4967", async() => {
                BeginContext(152, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(158, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a8b355d08d1cd00ef3268a7c929d658bfcdb83de5352", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(235, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(246, 759, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b355d08d1cd00ef3268a7c929d658bfcdb83de7567", async() => {
                BeginContext(252, 232, true);
                WriteLiteral("\r\n    <div id=\"manage-page\">\r\n        <h4 class=\"main-text\">Events management</h4>\r\n        <div id=\"events-table-container\">\r\n            <table id=\"events-table\" class=\"table-responsive table-bordered table-striped table-hover\">\r\n");
                EndContext();
#line 17 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
                 foreach (var e in Model)
                {

#line default
#line hidden
                BeginContext(546, 23, true);
                WriteLiteral("                    <tr");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 569, "\"", 602, 3);
                WriteAttributeValue("", 579, "handleTableClick(", 579, 17, true);
#line 19 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
WriteAttributeValue("", 596, e.Id, 596, 5, false);

#line default
#line hidden
                WriteAttributeValue("", 601, ")", 601, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 603, "\"", 636, 1);
#line 19 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
WriteAttributeValue("", 608, "event-"+e.Id.ToString() , 608, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(637, 31, true);
                WriteLiteral(">\r\n                        <td>");
                EndContext();
                BeginContext(669, 6, false);
#line 20 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
                       Write(e.Name);

#line default
#line hidden
                EndContext();
                BeginContext(675, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(711, 15, false);
#line 21 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
                       Write(e.Location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(726, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(762, 6, false);
#line 22 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
                       Write(e.Date);

#line default
#line hidden
                EndContext();
                BeginContext(768, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 24 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\ManagerMenu.cshtml"
                }

#line default
#line hidden
                BeginContext(821, 136, true);
                WriteLiteral("            </table>\r\n        </div>\r\n        <button id=\"add-button\" class=\"btn btn-primary\">Add new event</button>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(957, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8b355d08d1cd00ef3268a7c929d658bfcdb83de11185", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(996, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1005, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<iNeedTickets.Models.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
