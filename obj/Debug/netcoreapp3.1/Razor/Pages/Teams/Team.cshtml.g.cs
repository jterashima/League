#pragma checksum "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76d01c7596881572cb3856d89228aa6b9ab6150f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Team), @"mvc.1.0.razor-page", @"/Pages/Teams/Team.cshtml")]
namespace League.Pages.Teams
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
#line 1 "C:\Users\owner\source\repos\League\League\Pages\_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owner\source\repos\League\League\Pages\_ViewImports.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d01c7596881572cb3856d89228aa6b9ab6150f", @"/Pages/Teams/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3ff45e0845b767ce2e91c14cb4035fde88f59", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Teams_Team : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("links"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n    <h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76d01c7596881572cb3856d89228aa6b9ab6150f3875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 81, "~/image/nfl/logo/", 81, 17, true);
#nullable restore
#line 7 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 98, Model.Team.TeamId, 98, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 118, ".png", 118, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 7 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                                          Write(Model.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 7 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                                                                Write(Model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"d-flex justify-content-between\">\r\n    <div class=\"d-block\">\r\n        <div>");
#nullable restore
#line 12 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
         Write(Model.Team.Division.ConferenceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                              Write(Model.Team.DivisionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>Record: ");
#nullable restore
#line 13 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                 Write(Model.Team.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 13 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                   Write(Model.Team.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 13 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                                     Write(Model.Team.Tie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <hr />\r\n        <div>");
#nullable restore
#line 15 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
        Write(Model.Team.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 16 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
        Write(Model.Team.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <hr />\r\n        <div>");
#nullable restore
#line 18 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
        Write(Model.Team.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 19 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
         Write(Model.Team.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 19 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                            Write(Model.Team.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                              Write(Model.Team.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76d01c7596881572cb3856d89228aa6b9ab6150f8760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 661, "~/image/nfl/stadium/", 661, 20, true);
#nullable restore
#line 20 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 681, Model.Team.TeamId, 681, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 701, ".jpg", 701, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"d-flex\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76d01c7596881572cb3856d89228aa6b9ab6150f10359", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 767, "~/image/nfl/seating/", 767, 20, true);
#nullable restore
#line 23 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 787, Model.Team.TeamId, 787, 20, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 807, ".png", 807, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<br />

<div class=""d-flex bg-primary text-white"">
    <div class=""p-1"" style=""flex:0 0 10%"">Number</div>
    <div class=""p-1"" style=""flex:0 0 25%"">Name</div>
    <div class=""p-1"" style=""flex:0 0 10%"">Position</div>
    <div class=""p-1"" style=""flex:0 0 20%"">Experience</div>
    <div class=""p-1"" style=""flex:0 0 25%"">College</div>
</div>

");
#nullable restore
#line 36 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
 foreach (Player player in Model.Team.Players)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76d01c7596881572cb3856d89228aa6b9ab6150f12530", async() => {
                WriteLiteral("\r\n        <div class=\"d-flex text-black-50\">\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 40 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                             Write(player.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 41 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                             Write(player.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 42 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                             Write(player.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 20%\">");
#nullable restore
#line 43 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                             Write(player.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 44 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                             Write(player.College);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PlayerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
                                                 WriteLiteral(player.PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PlayerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PlayerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PlayerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\owner\source\repos\League\League\Pages\Teams\Team.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel>)PageContext?.ViewData;
        public TeamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
