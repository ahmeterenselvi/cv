#pragma checksum "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72201db7c07fea92cb36bf523b8d068fd26d9694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Shared_Components_NotificationList_Default), @"mvc.1.0.view", @"/Areas/User/Views/Shared/Components/NotificationList/Default.cshtml")]
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
#line 1 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72201db7c07fea92cb36bf523b8d068fd26d9694", @"/Areas/User/Views/Shared/Components/NotificationList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Shared_Components_NotificationList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <p class=\"mb-0 font-weight-normal float-left dropdown-header\">Notifications</p>\r\n");
#nullable restore
#line 6 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
     foreach (var value in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 347, "\"", 398, 3);
            WriteAttributeValue("", 354, "/User/Default/AnnouncementDetails/", 354, 34, true);
#nullable restore
#line 8 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
WriteAttributeValue("", 388, value.Id, 388, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 397, "/", 397, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"preview-thumbnail\">\r\n");
#nullable restore
#line 10 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
                 if (value.Status == "Aktif")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"preview-icon bg-success\">\r\n                        <i class=\"ti-info-alt mx-0\"></i>\r\n                    </div>\r\n");
#nullable restore
#line 15 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"preview-icon bg-danger\">\r\n                        <i class=\"ti-info-alt mx-0\"></i>\r\n                    </div>\r\n");
#nullable restore
#line 21 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"preview-item-content\">\r\n                <h6 class=\"preview-subject font-weight-normal\">");
#nullable restore
#line 24 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
                                                          Write(value.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"font-weight-light small-text mb-0 text-muted\">\r\n                    ");
#nullable restore
#line 26 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
               Write(value.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 30 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Shared\Components\NotificationList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
