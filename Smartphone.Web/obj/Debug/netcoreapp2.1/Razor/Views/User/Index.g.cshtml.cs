#pragma checksum "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86935ece71e895c5f1ba352811a491f1bf4db49f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\_ViewImports.cshtml"
using Smartphone.Web;

#line default
#line hidden
#line 2 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\_ViewImports.cshtml"
using Smartphone.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
using Smartphone.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86935ece71e895c5f1ba352811a491f1bf4db49f", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef859d2b78e35f5098f25bf23f45f75871183312", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(80, 3, true);
            WriteLiteral("\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 83, "\"", 128, 2);
            WriteAttributeValue("", 90, "/User/GetSmartphonesByUserId/", 90, 29, true);
#line 7 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 119, Model.Id, 119, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(129, 8, true);
            WriteLiteral(" >Check ");
            EndContext();
            BeginContext(138, 14, false);
#line 7 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
                                                   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(152, 20, true);
            WriteLiteral("\'s Smartphones</a>\n\n");
            EndContext();
            BeginContext(173, 10, false);
#line 9 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
Write(Model.City);

#line default
#line hidden
            EndContext();
            BeginContext(183, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(185, 15, false);
#line 10 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(200, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(202, 14, false);
#line 11 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(216, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(218, 17, false);
#line 12 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\User\Index.cshtml"
Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(235, 4, true);
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
