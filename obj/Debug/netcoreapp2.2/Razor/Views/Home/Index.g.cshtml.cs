#pragma checksum "D:\Work\trorapu\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deffef4e77ccaabb287289b7b37b06cbb99a8ecd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deffef4e77ccaabb287289b7b37b06cbb99a8ecd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d1d5183ef2cd83c64a380014fe7d3d64a575d5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Work\trorapu\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\Work\trorapu\Views\Home\Index.cshtml"
 if (ViewData["ShowAlert"] != null && (bool) ViewData["ShowAlert"] == true)
 {

#line default
#line hidden
            BeginContext(128, 71, true);
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ขอขอบคุณคุณ");
            EndContext();
            BeginContext(201, 16, false);
#line 8 "D:\Work\trorapu\Views\Home\Index.cshtml"
               Write(ViewData["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(218, 24, true);
            WriteLiteral(" ทางเราจะติดต่อกลับไปที่");
            EndContext();
            BeginContext(244, 17, false);
#line 8 "D:\Work\trorapu\Views\Home\Index.cshtml"
                                                          Write(ViewData["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(262, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(286, 21, true);
            WriteLiteral("\r\n        ขอบคุณครับ ");
            EndContext();
            BeginContext(308, 21, false);
#line 11 "D:\Work\trorapu\Views\Home\Index.cshtml"
              Write(ViewData["ShowAlert"]);

#line default
#line hidden
            EndContext();
            BeginContext(329, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(342, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(350, 40, true);
            WriteLiteral("ข้อความนี้เป็นข้อความใน HTML ไม่ใช่ C#\r\n");
            EndContext();
#line 14 "D:\Work\trorapu\Views\Home\Index.cshtml"
 }

#line default
#line hidden
            BeginContext(394, 187, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>");
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
