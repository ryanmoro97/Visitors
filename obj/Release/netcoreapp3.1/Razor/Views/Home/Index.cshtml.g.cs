#pragma checksum "/Users/frostytits/FINALSEM/COMP466/TMA3A/part1/part1/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593be24c90351e0fcdf54974c3d3e1b34e4899ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/frostytits/FINALSEM/COMP466/TMA3A/part1/part1/Views/_ViewImports.cshtml"
using part1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/frostytits/FINALSEM/COMP466/TMA3A/part1/part1/Views/_ViewImports.cshtml"
using part1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593be24c90351e0fcdf54974c3d3e1b34e4899ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a359a1309afb1d4dfe8f6e259584313c4fcaacc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/frostytits/FINALSEM/COMP466/TMA3A/part1/part1/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p id=\"hits\">Times you have visited this page: ");
#nullable restore
#line 10 "/Users/frostytits/FINALSEM/COMP466/TMA3A/part1/part1/Views/Home/Index.cshtml"
                                              Write(ViewData["visits"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p id=\"ip\">Your ip address: ");
#nullable restore
#line 11 "/Users/frostytits/FINALSEM/COMP466/TMA3A/part1/part1/Views/Home/Index.cshtml"
                           Write(ViewData["ip"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p id=\"timezone\">Your time zone: UTC </p>\n</div>");
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
