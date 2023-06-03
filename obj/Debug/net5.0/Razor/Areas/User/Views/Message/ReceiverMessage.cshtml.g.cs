#pragma checksum "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad7215c65d1bd3eaa8aa072d3c617918decbaf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Message_ReceiverMessage), @"mvc.1.0.view", @"/Areas/User/Views/Message/ReceiverMessage.cshtml")]
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
#line 3 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ad7215c65d1bd3eaa8aa072d3c617918decbaf8", @"/Areas/User/Views/Message/ReceiverMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Message_ReceiverMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
  
    ViewData["Title"] = "ReceiverMessage";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Messages</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Sender</th>
                            <th>Receiver</th>
                            <th>Subject</th>
                            <th>Date</th>
                            <th>Details</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                         foreach (var value in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 28 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                               Write(value.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                               Write(value.Sender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                               Write(value.Receiver);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                               Write(value.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                               Write(value.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1267, 2);
            WriteAttributeValue("", 1229, "/User/Message/MessageDetails/", 1229, 29, true);
#nullable restore
#line 33 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
WriteAttributeValue("", 1258, value.Id, 1258, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-behance\">Details</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Message\ReceiverMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                    <tr>
                        <th>Send a Message</th>
                        <td><a href=""/User/Message/SendMessage/"" class=""btn btn-outline-primary"">Go</a></td>
                    </tr>
                    <tr>
                        <th>Sent Messages</th>
                        <td><a href=""/User/Message/SenderMessage/"" class=""btn btn-outline-primary"">Go</a></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
