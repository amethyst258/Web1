#pragma checksum "D:\Work\trorapu\Views\Home\Plus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cdd66da0cf986a60d0736862d9d36642a71a542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Plus), @"mvc.1.0.view", @"/Views/Home/Plus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Plus.cshtml", typeof(AspNetCore.Views_Home_Plus))]
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
#line 1 "D:\Work\trorapu\Views\_ViewImports.cshtml"
using trorapu;

#line default
#line hidden
#line 2 "D:\Work\trorapu\Views\_ViewImports.cshtml"
using trorapu.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdd66da0cf986a60d0736862d9d36642a71a542", @"/Views/Home/Plus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d1d5183ef2cd83c64a380014fe7d3d64a575d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Plus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Work\trorapu\Views\Home\Plus.cshtml"
  
    ViewData["Title"] = "Plus";

#line default
#line hidden
            BeginContext(42, 33, true);
            WriteLiteral("\r\n<h1>Plus</h1>\r\n\r\nPlus value is ");
            EndContext();
            BeginContext(76, 15, false);
#line 8 "D:\Work\trorapu\Views\Home\Plus.cshtml"
         Write(ViewData["sum"]);

#line default
#line hidden
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
