#pragma checksum "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43cc98cb4e7af5fc01d86e228a967dfbbcbf090b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserTickets), @"mvc.1.0.view", @"/Views/Account/UserTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/UserTickets.cshtml", typeof(AspNetCore.Views_Account_UserTickets))]
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
#line 1 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\_ViewImports.cshtml"
using iNeedTickets;

#line default
#line hidden
#line 2 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\_ViewImports.cshtml"
using iNeedTickets.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43cc98cb4e7af5fc01d86e228a967dfbbcbf090b", @"/Views/Account/UserTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f60ed2231cd9183c3fcd360565fba6d163d9627b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<iNeedTickets.Models.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/usertickets.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
  
    ViewData["Title"] = "UserTickets";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 16, true);
            WriteLiteral("\r\n<html>\r\n\r\n    ");
            EndContext();
            BeginContext(160, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43cc98cb4e7af5fc01d86e228a967dfbbcbf090b5001", async() => {
                BeginContext(166, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(176, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43cc98cb4e7af5fc01d86e228a967dfbbcbf090b5391", async() => {
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
                BeginContext(246, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(259, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(267, 1088, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43cc98cb4e7af5fc01d86e228a967dfbbcbf090b7619", async() => {
                BeginContext(273, 47, true);
                WriteLiteral("\r\n\r\n        <div id=\"purchased-tickets-page\">\r\n");
                EndContext();
#line 17 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
             if (Model.ToList().Count > 0)
            {

#line default
#line hidden
                BeginContext(379, 232, true);
                WriteLiteral("                <h4 class=\"main-text\">Your purchased tickets:</h4>\r\n                <div id=\"ticket-list-container\">\r\n                    <table id=\"tickets-table\" class=\"table-responsive table-bordered table-striped table-hover\">\r\n");
                EndContext();
#line 22 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
                         foreach (var ticket in Model)
                        {

#line default
#line hidden
                BeginContext(694, 130, true);
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <a class=\"ticket-link\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 824, "\"", 857, 2);
                WriteAttributeValue("", 831, "/account/ticket/", 831, 16, true);
#line 26 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
WriteAttributeValue("", 847, ticket.Id, 847, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(858, 43, true);
                WriteLiteral(">\r\n                                        ");
                EndContext();
                BeginContext(902, 28, false);
#line 27 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
                                   Write(ticket.TicketArea.Event.Name);

#line default
#line hidden
                EndContext();
                BeginContext(930, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(934, 26, false);
#line 27 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
                                                                   Write(ticket.TicketArea.AreaName);

#line default
#line hidden
                EndContext();
                BeginContext(960, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(964, 28, false);
#line 27 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
                                                                                                 Write(ticket.TicketArea.Event.Date);

#line default
#line hidden
                EndContext();
                BeginContext(992, 118, true);
                WriteLiteral("\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
                EndContext();
#line 31 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
                        }

#line default
#line hidden
                BeginContext(1137, 58, true);
                WriteLiteral("                        </table>\r\n                </div>\r\n");
                EndContext();
#line 34 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1243, 70, true);
                WriteLiteral("                <div>You don\'t have any purchased tickets yet!</div>\r\n");
                EndContext();
#line 38 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Views\Account\UserTickets.cshtml"
            }

#line default
#line hidden
                BeginContext(1328, 20, true);
                WriteLiteral("        </div>\r\n    ");
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
            BeginContext(1355, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<iNeedTickets.Models.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
