#pragma checksum "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288f84abd84159240b839f4cf26ff737bf5d2d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manager_AddEvent), @"mvc.1.0.view", @"/Areas/Admin/Views/Manager/AddEvent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manager/AddEvent.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manager_AddEvent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"288f84abd84159240b839f4cf26ff737bf5d2d01", @"/Areas/Admin/Views/Manager/AddEvent.cshtml")]
    public class Areas_Admin_Views_Manager_AddEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<iNeedTickets.Models.Location>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin/add-event.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/add-event.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
  
    ViewData["Title"] = "AddEvent";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
   var eventCategories = new Dictionary<int, string>()
    {
       {1, "Concerts" },
       {2, "Theatre" },
       {3, "Sports" },
       {4, "Standup" },
       {5, "Art" }
    };

#line default
#line hidden
            BeginContext(332, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(342, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "288f84abd84159240b839f4cf26ff737bf5d2d015383", async() => {
                BeginContext(348, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(354, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "288f84abd84159240b839f4cf26ff737bf5d2d015768", async() => {
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
                BeginContext(428, 2, true);
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
            BeginContext(437, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(439, 2311, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "288f84abd84159240b839f4cf26ff737bf5d2d017984", async() => {
                BeginContext(445, 566, true);
                WriteLiteral(@"
    <div id=""add-event-page"">
        <div id=""event-details"" class=""border-right"">
            <h4 class=""main-text"">Add a new event:</h4>

            <label class=""form-label"">Event name:</label>
            <input id=""name-field"" type=""text"" class=""form-element form-control"" />

            <label class=""form-label"">Date:</label>
            <input id=""date-field"" type=""date"" class=""form-element form-control"" />

            <label class=""form-label"">Location:</label>
            <select id=""location-field"" class=""form-element form-control"">
");
                EndContext();
#line 35 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
                 foreach (var location in Model)
                {

#line default
#line hidden
                BeginContext(1080, 27, true);
                WriteLiteral("                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1107, "\"", 1127, 1);
#line 37 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
WriteAttributeValue("", 1115, location.Id, 1115, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1128, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1130, 13, false);
#line 37 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
                                            Write(location.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1143, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 38 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
                }

#line default
#line hidden
                BeginContext(1173, 158, true);
                WriteLiteral("            </select>\r\n\r\n            <label class=\"form-label\">Category:</label>\r\n            <select id=\"category-field\" class=\"form-element form-control\">\r\n");
                EndContext();
#line 43 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
                 foreach (var c in eventCategories)
                {

#line default
#line hidden
                BeginContext(1403, 27, true);
                WriteLiteral("                    <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1430, "\"", 1444, 1);
#line 45 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
WriteAttributeValue("", 1438, c.Key, 1438, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1445, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1447, 7, false);
#line 45 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
                                      Write(c.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1454, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 46 "C:\Users\Mihail\Documents\Git Repos\iNeedTickets\iNeedTickets\Areas\Admin\Views\Manager\AddEvent.cshtml"
                }

#line default
#line hidden
                BeginContext(1484, 1216, true);
                WriteLiteral(@"            </select>

            <label class=""form-label"">Description:</label>
            <textarea id=""description-field"" class=""form-element form-control""></textarea>

            <label class=""form-label"">Add an image:</label>
            <input id=""photo-field"" type=""file"" accept=""image/*"" class=""form-element form-control-file"" />

            <button id=""add-event-button"" class=""btn btn-primary"">Submit</button>
            <div id=""error-message""></div>
        </div>
        <div id=""area-details"">
            <h4 class=""main-text"">Ticket areas:</h4>
            <div id=""types-container"">
                <div class=""type-container"">
                    <span>Area 1:</span>
                    <input type=""text"" id=""area-name-1"" class=""area-details form-control"" placeholder=""Name"" />
                    <input type=""number"" id=""area-price-1"" class=""area-details form-control"" placeholder=""Price"" />
                    <input type=""number"" id=""area-capacity-1"" class=""area-details form");
                WriteLiteral("-control\" placeholder=\"Capacity\" />\r\n                </div>\r\n            </div>\r\n            <button id=\"add-area\" class=\"btn btn-primary\">Add area</button>\r\n        </div>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(2700, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "288f84abd84159240b839f4cf26ff737bf5d2d0113433", async() => {
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
                BeginContext(2741, 2, true);
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
            BeginContext(2750, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<iNeedTickets.Models.Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591