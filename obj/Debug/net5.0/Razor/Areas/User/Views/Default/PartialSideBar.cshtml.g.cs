#pragma checksum "C:\Users\ahmet\Desktop\C#\Murat Yücedağ\UdemyProjectCV\Core_Proje\Areas\User\Views\Default\PartialSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e19393479c61b9b0de26fd0cd4961fd0bc900a9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Default_PartialSideBar), @"mvc.1.0.view", @"/Areas/User/Views/Default/PartialSideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e19393479c61b9b0de26fd0cd4961fd0bc900a9d", @"/Areas/User/Views/Default/PartialSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1666001c2ad5ef6477b3166cd500a7db9edb1", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Default_PartialSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e19393479c61b9b0de26fd0cd4961fd0bc900a9d3611", async() => {
                WriteLiteral(@"
    <style>
        /* Sidebar stilini düzenle */
        .sidebar {
            color: #ffffff; /* Yazı rengi */
            width: 250px; /* Genişlik */
        }

            .sidebar ul.nav {
                padding: 0;
                margin: 0;
                list-style-type: none;
            }

                .sidebar ul.nav li {
                    padding: 10px;
                    border-bottom: 1px solid #333333;
                }

                    .sidebar ul.nav li:last-child {
                        border-bottom: none;
                    }

                    .sidebar ul.nav li a {
                        color: #ffffff;
                        text-decoration: none;
                    }

                        .sidebar ul.nav li a:hover {
                            color: #ff0000; /* Vurgu rengi */
                        }

            .sidebar .menu-icon {
                margin-right: 10px;
            }

            .sidebar .menu-title {
 ");
                WriteLiteral("               font-weight: bold;\r\n            }\r\n    </style>\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css\">\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e19393479c61b9b0de26fd0cd4961fd0bc900a9d5825", async() => {
                WriteLiteral(@"
    <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
        <ul class=""nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Dashboard/Index/"">
                    <i class=""fas fa-tachometer-alt menu-icon""></i>
                    <span class=""menu-title"">Dashboard</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Message/ReceiverMessage/"">
                    <i class=""fas fa-envelope menu-icon""></i>
                    <span class=""menu-title"">Received Messages</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Message/SenderMessage/"">
                    <i class=""fas fa-paper-plane menu-icon""></i>
                    <span class=""menu-title"">Sent Messages</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Message/Se");
                WriteLiteral(@"ndMessage/"">
                    <i class=""fas fa-comments menu-icon""></i>
                    <span class=""menu-title"">Send a Message</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Default/Index/"">
                    <i class=""fas fa-bullhorn menu-icon""></i>
                    <span class=""menu-title"">Announcements</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Profile/Index/"">
                    <i class=""fas fa-user menu-icon""></i>
                    <span class=""menu-title"">Profile</span>
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/User/Profile/Index/"">
                    <i class=""fas fa-cog menu-icon""></i>
                    <span class=""menu-title"">Settings</span>
                </a>
            </li>
            <li class=""nav-item"">
       ");
                WriteLiteral("         <a class=\"nav-link\" href=\"/User/Login/LogOut\">\r\n                    <i class=\"fas fa-sign-out-alt menu-icon\"></i>\r\n                    <span class=\"menu-title\">Log Off</span>\r\n                </a>\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
