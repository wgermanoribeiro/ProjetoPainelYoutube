#pragma checksum "C:\Users\wellingtonribeiro\source\repos\ProjetoPainelYoutube\ProjetoPainelYoutube\Views\Shared\Components\Google1ViewComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88706ec8e566906c719863f4f69b491e20c5d382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Google1ViewComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Google1ViewComponent/Default.cshtml")]
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
#line 1 "C:\Users\wellingtonribeiro\source\repos\ProjetoPainelYoutube\ProjetoPainelYoutube\Views\_ViewImports.cshtml"
using ProjetoPainelYoutube;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wellingtonribeiro\source\repos\ProjetoPainelYoutube\ProjetoPainelYoutube\Views\_ViewImports.cshtml"
using ProjetoPainelYoutube.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\wellingtonribeiro\source\repos\ProjetoPainelYoutube\ProjetoPainelYoutube\Views\Shared\Components\Google1ViewComponent\Default.cshtml"
using ProjetoPainelYoutube.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88706ec8e566906c719863f4f69b491e20c5d382", @"/Views/Shared/Components/Google1ViewComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6bf1420b4ba65164583b5279e06f00f41309262", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Google1ViewComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Google1ViewComponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"m-2\">\r\n    <div class=\"row card border-danger col-sm m-1\">        \r\n        <img");
            BeginWriteAttribute("src", " src=\"", 165, "\"", 171, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\" class=\"m-0\"/>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 244, 1);
#nullable restore
#line 8 "C:\Users\wellingtonribeiro\source\repos\ProjetoPainelYoutube\ProjetoPainelYoutube\Views\Shared\Components\Google1ViewComponent\Default.cshtml"
WriteAttributeValue("", 230, Model.Google1, 230, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Mapa</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Google1ViewComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591