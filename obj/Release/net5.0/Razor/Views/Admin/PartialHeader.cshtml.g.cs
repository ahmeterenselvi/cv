#pragma checksum "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Admin\PartialHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f06f3c59c0e11b9badf38d8e71dc17b97a70187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialHeader), @"mvc.1.0.view", @"/Views/Admin/PartialHeader.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f06f3c59c0e11b9badf38d8e71dc17b97a70187", @"/Views/Admin/PartialHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialHeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""header bg-primary pb-6"">
    <div class=""container-fluid"">
        <div class=""header-body"">
            <div class=""row align-items-center py-4"">
                <div class=""col-lg-6 col-7"">
                    <h6 class=""h2 text-white d-inline-block mb-0"">");
#nullable restore
#line 6 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Admin\PartialHeader.cshtml"
                                                             Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <nav aria-label=""breadcrumb"" class=""d-none d-md-inline-block ml-md-4"">
                        <ol class=""breadcrumb breadcrumb-links breadcrumb-dark"">
                            <li class=""breadcrumb-item""><a href=""#""><i class=""fas fa-home""></i></a></li>
                            <li class=""breadcrumb-item""><a href=""#"">");
#nullable restore
#line 10 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Admin\PartialHeader.cshtml"
                                                               Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 11 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Views\Admin\PartialHeader.cshtml"
                                                                              Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ol>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
