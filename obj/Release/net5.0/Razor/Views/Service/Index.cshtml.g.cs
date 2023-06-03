#pragma checksum "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6350c88ac4b5e7fb6c9a64ec605dff3363cfec55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6350c88ac4b5e7fb6c9a64ec605dff3363cfec55", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0 text-center"">
                <h3 class=""text-white mb-0"">Services</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""service-id"">Service Id</th>
                            <th scope=""col"" class=""sort"" data-sort=""title"">Title</th>
                            <th scope=""col"" class=""sort"" data-sort=""image"">Image</th>
                            <th scope=""col"" class=""sort"" data-sort=""actions"">Actions</th>
                        </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 25 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
                         foreach (var value in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"service-id\">\r\n                                    <span class=\"text-white\">");
#nullable restore
#line 29 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
                                                        Write(value.ServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td class=\"title\">\r\n                                    <span class=\"text-white\">");
#nullable restore
#line 32 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
                                                        Write(value.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n                                <td class=\"image\">\r\n                                    <img alt=\"Service Image\"");
            BeginWriteAttribute("src", " src=\"", 1615, "\"", 1636, 1);
#nullable restore
#line 35 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1621, value.ImageUrl, 1621, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""rounded-circle img-fluid"" height=""48"" width=""48"">
                                </td>
                                <td class=""actions"">
                                    <div class=""d-flex justify-content-md-start"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1914, "\"", 1958, 2);
            WriteAttributeValue("", 1921, "/Service/EditService/", 1921, 21, true);
#nullable restore
#line 39 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1942, value.ServiceId, 1942, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success mr-2\">Edit</a>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6350c88ac4b5e7fb6c9a64ec605dff3363cfec557586", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-danger\" onclick=\"return confirm(\'Are you sure you want to delete this service?\')\">Delete</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2053, "/Service/DeleteService/", 2053, 23, true);
#nullable restore
#line 40 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
AddHtmlAttributeValue("", 2076, value.ServiceId, 2076, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 2604, "\"", 2636, 1);
#nullable restore
#line 56 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 2611, Url.Action("AddService"), 2611, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Add New Service</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
