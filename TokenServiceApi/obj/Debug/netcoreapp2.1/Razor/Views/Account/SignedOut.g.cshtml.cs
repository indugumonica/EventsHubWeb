#pragma checksum "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\Account\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f49014d0b9f63827b0d0d922dd53a76e52fe6e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignedOut), @"mvc.1.0.view", @"/Views/Account/SignedOut.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/SignedOut.cshtml", typeof(AspNetCore.Views_Account_SignedOut))]
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
#line 1 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi;

#line default
#line hidden
#line 3 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models;

#line default
#line hidden
#line 4 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\_ViewImports.cshtml"
using TokenServiceApi.Models.ManageViewModels;

#line default
#line hidden
#line 6 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f49014d0b9f63827b0d0d922dd53a76e52fe6e4", @"/Views/Account/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91778f8bb87e5f4bb91cb5620021eb17fa33f8dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\Account\SignedOut.cshtml"
  
    ViewData["Title"] = "Signed out";

#line default
#line hidden
            BeginContext(43, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 5 "C:\Users\Monica\Desktop\Kal\EventsHub\EventsHub\TokenServiceApi\Views\Account\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 53, true);
            WriteLiteral("</h2>\n<p>\n    You have successfully signed out.\n</p>\n");
            EndContext();
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
