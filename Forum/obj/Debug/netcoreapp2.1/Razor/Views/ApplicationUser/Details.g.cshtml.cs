#pragma checksum "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "564e6ee68204d5d2527cb0c21326411974ef1514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUser_Details), @"mvc.1.0.view", @"/Views/ApplicationUser/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApplicationUser/Details.cshtml", typeof(AspNetCore.Views_ApplicationUser_Details))]
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
#line 1 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\_ViewImports.cshtml"
using Forum;

#line default
#line hidden
#line 2 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\_ViewImports.cshtml"
using Forum.Models;

#line default
#line hidden
#line 2 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"564e6ee68204d5d2527cb0c21326411974ef1514", @"/Views/ApplicationUser/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac609fd15eba99a48942b04c8579a10a24406fb", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationUser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Forum.Models.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;height:300px;border:0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(127, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(172, 44, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n\r\n\r\n<div>\r\n    <h4><b>");
            EndContext();
            BeginContext(217, 36, false);
#line 15 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
      Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(253, 108, true);
            WriteLiteral("</b></h4>\r\n    <hr />\r\n    <table border-spacing=\"50px 0\">\r\n        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(361, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "657d2486813f4e0e92a0f9f38b23baa1", async() => {
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
            BeginContext(452, 160, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td style=\"margin: 10px; padding: 50px;\">\r\n                <table>\r\n                    <tr>\r\n                        <td><b>");
            EndContext();
            BeginContext(613, 45, false);
#line 26 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(658, 39, true);
            WriteLiteral("</b></td>\r\n                        <td>");
            EndContext();
            BeginContext(698, 41, false);
#line 27 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(739, 91, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>");
            EndContext();
            BeginContext(831, 44, false);
#line 30 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(875, 39, true);
            WriteLiteral("</b></td>\r\n                        <td>");
            EndContext();
            BeginContext(915, 40, false);
#line 31 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(955, 91, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>");
            EndContext();
            BeginContext(1047, 43, false);
#line 34 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 40, true);
            WriteLiteral("</b></td>\r\n                        <td> ");
            EndContext();
            BeginContext(1131, 39, false);
#line 35 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                        Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 91, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>");
            EndContext();
            BeginContext(1262, 40, false);
#line 38 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 40, true);
            WriteLiteral("</b></td>\r\n                        <td> ");
            EndContext();
            BeginContext(1343, 36, false);
#line 39 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                        Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 92, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b> ");
            EndContext();
            BeginContext(1472, 47, false);
#line 42 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 40, true);
            WriteLiteral("</b></td>\r\n                        <td> ");
            EndContext();
            BeginContext(1560, 43, false);
#line 43 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                        Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 91, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>");
            EndContext();
            BeginContext(1695, 41, false);
#line 46 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 40, true);
            WriteLiteral("</b></td>\r\n                        <td> ");
            EndContext();
            BeginContext(1777, 37, false);
#line 47 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                        Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1814, 91, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td><b>");
            EndContext();
            BeginContext(1906, 45, false);
#line 50 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 40, true);
            WriteLiteral("</b></td>\r\n                        <td> ");
            EndContext();
            BeginContext(1992, 41, false);
#line 51 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
                        Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(2033, 122, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n\r\n        </tr>\r\n\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
#line 61 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
 if (@UserManager.GetUserName(User) == Model.UserName)
{

#line default
#line hidden
            BeginContext(2214, 34, true);
            WriteLiteral("    <div align=\"center\">\r\n        ");
            EndContext();
            BeginContext(2248, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23982262b3ef4e938d1a13ab0189ff9e", async() => {
                BeginContext(2293, 12, true);
                WriteLiteral("Edit Profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2309, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 66 "D:\Facultate\Master\Anul1Sem1\WSE - Web System Engineering\Teme\Tema2 - proiect\NumiForum_unitTest\Forum\Views\ApplicationUser\Details.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Forum.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
