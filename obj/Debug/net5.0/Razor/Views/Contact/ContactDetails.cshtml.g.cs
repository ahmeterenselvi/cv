#pragma checksum "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e447bb86033e95715741eda5f4b021e9ec2847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactDetails), @"mvc.1.0.view", @"/Views/Contact/ContactDetails.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e447bb86033e95715741eda5f4b021e9ec2847", @"/Views/Contact/ContactDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ContactDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
  
    ViewData["Title"] = "ContactDetails";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Message Details</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <tr>
                        <th>Name:</th>
                        <td>");
#nullable restore
#line 16 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Mail:</th>\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                       Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Content:</th>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                       Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Date:</th>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                       Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Status:</th>\r\n                        <td>\r\n");
#nullable restore
#line 33 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                             if (Model.Status)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"badge badge-success\">");
#nullable restore
#line 35 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                                                          Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 36 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"badge badge-danger\">");
#nullable restore
#line 39 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                                                         Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 40 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Contact\ContactDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Back</th>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e447bb86033e95715741eda5f4b021e9ec28478044", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
