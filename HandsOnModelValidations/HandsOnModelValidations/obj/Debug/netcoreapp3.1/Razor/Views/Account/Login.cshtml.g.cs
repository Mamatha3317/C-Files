#pragma checksum "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "882ca97d7cc843d68212bd889920e796a679fadd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\_ViewImports.cshtml"
using HandsOnModelValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\_ViewImports.cshtml"
using HandsOnModelValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"882ca97d7cc843d68212bd889920e796a679fadd", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca8e6c37953a5766f725359e896b8bd6bfc690b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnModelValidations.Models.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 8 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
 using(Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 12 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
           Write(Html.DisplayNameFor(m=>m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
           Write(Html.EditorFor(m=>m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(m=>m.Uname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
           Write(Html.DisplayNameFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
           Write(Html.EditorFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(m => m.Pwd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        \r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <input type=\"submit\" value=\"Login\" />\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 28 "D:\so\HandsOnModelValidations\HandsOnModelValidations\Views\Account\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnModelValidations.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
