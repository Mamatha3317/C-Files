#pragma checksum "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "666b072bc509f961d20770829c1d9fd70a4b5945"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
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
#line 1 "D:\so\HandsOnMVC\HandsOnMVC\Views\_ViewImports.cshtml"
using HandsOnMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\so\HandsOnMVC\HandsOnMVC\Views\_ViewImports.cshtml"
using HandsOnMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"666b072bc509f961d20770829c1d9fd70a4b5945", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d41a8ec0aa709a845476761b110ed6cf1a32e868", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnMVC.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create</h1>\r\n");
#nullable restore
#line 8 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table \">\r\n    <tr>\r\n        <td>Name</td>\r\n        <td>");
#nullable restore
#line 13 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.TextBox("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 14 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email</td>\r\n        <td>");
#nullable restore
#line 18 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.TextBox("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>DOB</td>\r\n        <td>");
#nullable restore
#line 24 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.TextBox("DOB"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n    <tr>\r\n        <td>Mobile</td>\r\n        <td>");
#nullable restore
#line 30 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.TextBox("Mobile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Country</td>\r\n        <td>\r\n            ");
#nullable restore
#line 36 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.DropDownListFor(m => m.Country,new SelectList(new String[] { "india", "China", "US", "UK" })));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <td>UserName</td>\r\n        <td>");
#nullable restore
#line 43 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.TextBox("Uname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 44 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Password</td>\r\n        <td>");
#nullable restore
#line 48 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.TextBox("Pwd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 49 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td colspan=\"2\">\r\n            <input type=\"submit\" value=\"Register\" />\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 57 "D:\so\HandsOnMVC\HandsOnMVC\Views\User\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnMVC.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591