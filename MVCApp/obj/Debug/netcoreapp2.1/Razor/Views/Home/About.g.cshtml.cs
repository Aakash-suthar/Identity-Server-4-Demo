#pragma checksum "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec23a87e97afe76956025c8158adeae09cd867a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\_ViewImports.cshtml"
using MVCApp;

#line default
#line hidden
#line 2 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\_ViewImports.cshtml"
using MVCApp.Models;

#line default
#line hidden
#line 1 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ec23a87e97afe76956025c8158adeae09cd867a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b47802e00e304f8aef4fc82147a7e0a84fae27f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 23, true);
            WriteLiteral("\n<h2>Claims</h2>\n\n<dl>\n");
            EndContext();
#line 6 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(112, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(125, 10, false);
#line 8 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(135, 18, true);
            WriteLiteral("</dt>\n        <dd>");
            EndContext();
            BeginContext(154, 11, false);
#line 9 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(165, 6, true);
            WriteLiteral("</dd>\n");
            EndContext();
#line 10 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(177, 11, true);
            WriteLiteral("</dl>\n\n<h1>");
            EndContext();
            BeginContext(189, 59, false);
#line 13 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
Write(await ViewContext.HttpContext.GetTokenAsync("access_token"));

#line default
#line hidden
            EndContext();
            BeginContext(248, 33, true);
            WriteLiteral("</h1>\n\n<h2>Properties</h2>\n\n<dl>\n");
            EndContext();
#line 18 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(367, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(380, 8, false);
#line 20 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(388, 18, true);
            WriteLiteral("</dt>\n        <dd>");
            EndContext();
            BeginContext(407, 10, false);
#line 21 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(417, 6, true);
            WriteLiteral("</dd>\n");
            EndContext();
#line 22 "C:\Users\aksuthar\Desktop\Solution1-master\MVCApp\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(429, 5, true);
            WriteLiteral("</dl>");
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
