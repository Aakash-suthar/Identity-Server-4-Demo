#pragma checksum "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb2218f45739d325162ffa5a3d66210d5af0ec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ScopeListItem.cshtml", typeof(AspNetCore.Views_Shared__ScopeListItem))]
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
#line 1 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb2218f45739d325162ffa5a3d66210d5af0ec0", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4c1f8a331756813dc62d0a9e9a6b6778f02506", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 152, true);
            WriteLiteral("\n<li class=\"list-group-item\">\n    <label>\n        <input class=\"consent-scopecheck\"\n               type=\"checkbox\"\n               name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", "\n               id=\"", 174, "\"", 212, 2);
            WriteAttributeValue("", 194, "scopes_", 194, 7, true);
#line 8 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 201, Model.Name, 201, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n               value=\"", 213, "\"", 247, 1);
#line 9 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 236, Model.Name, 236, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\n               checked=\"", 248, "\"", 287, 1);
#line 10 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 273, Model.Checked, 273, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\n               disabled=\"", 288, "\"", 329, 1);
#line 11 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 314, Model.Required, 314, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(330, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 12 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(373, 74, true);
            WriteLiteral("            <input type=\"hidden\"\n                   name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", "\n                   value=\"", 447, "\"", 485, 1);
#line 16 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 474, Model.Name, 474, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(486, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 17 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(500, 16, true);
            WriteLiteral("        <strong>");
            EndContext();
            BeginContext(517, 17, false);
#line 18 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(534, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
#line 19 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(584, 71, true);
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\n");
            EndContext();
#line 22 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(665, 13, true);
            WriteLiteral("    </label>\n");
            EndContext();
#line 24 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
            BeginContext(709, 41, true);
            WriteLiteral("        <span><em>(required)</em></span>\n");
            EndContext();
#line 27 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(756, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 28 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
            BeginContext(798, 60, true);
            WriteLiteral("        <div class=\"consent-description\">\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 858, "\"", 882, 2);
            WriteAttributeValue("", 864, "scopes_", 864, 7, true);
#line 31 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 871, Model.Name, 871, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(883, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(885, 17, false);
#line 31 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(902, 24, true);
            WriteLiteral("</label>\n        </div>\n");
            EndContext();
#line 33 "C:\Users\aksuthar\Desktop\Solution1-master\IdentityServer4App\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(932, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
