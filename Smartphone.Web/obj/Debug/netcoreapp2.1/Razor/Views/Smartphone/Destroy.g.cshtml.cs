#pragma checksum "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Destroy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241439df8d81107aabf035118744a165fa3484c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Smartphone_Destroy), @"mvc.1.0.view", @"/Views/Smartphone/Destroy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Smartphone/Destroy.cshtml", typeof(AspNetCore.Views_Smartphone_Destroy))]
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
#line 1 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\_ViewImports.cshtml"
using Smartphone.Web;

#line default
#line hidden
#line 2 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\_ViewImports.cshtml"
using Smartphone.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241439df8d81107aabf035118744a165fa3484c2", @"/Views/Smartphone/Destroy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de015ee87a5b2d18f6b83caa68e79075cd02c7ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Smartphone_Destroy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Destroy.cshtml"
  
    ViewData["Title"] = "Destroy";

#line default
#line hidden
            BeginContext(55, 66, true);
            WriteLiteral("\r\n<h2>Are you sure, you want to delete this Smartphone?</h2>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 121, "\"", 165, 2);
            WriteAttributeValue("", 128, "/smartphone/DeletingSmartphone/", 128, 31, true);
#line 8 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Destroy.cshtml"
WriteAttributeValue("", 159, Model, 159, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(166, 127, true);
            WriteLiteral(" class=\"btn btn-danger\">Confirm Delete</a>\r\n<a href=\"/smartphone/currentuseradvertisement\" class=\"btn btn-default\">Back</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
