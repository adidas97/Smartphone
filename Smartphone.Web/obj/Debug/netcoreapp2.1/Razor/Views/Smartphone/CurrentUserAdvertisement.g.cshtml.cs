#pragma checksum "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb0e35b75b69911c5e52493c4607be9ee99c8df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Smartphone_CurrentUserAdvertisement), @"mvc.1.0.view", @"/Views/Smartphone/CurrentUserAdvertisement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Smartphone/CurrentUserAdvertisement.cshtml", typeof(AspNetCore.Views_Smartphone_CurrentUserAdvertisement))]
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
#line 1 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
using Smartphone.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb0e35b75b69911c5e52493c4607be9ee99c8df", @"/Views/Smartphone/CurrentUserAdvertisement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef859d2b78e35f5098f25bf23f45f75871183312", @"/Views/_ViewImports.cshtml")]
    public class Views_Smartphone_CurrentUserAdvertisement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Advertisement>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
  
    ViewData["Title"] = "MySmartphones";

#line default
#line hidden
            BeginContext(104, 398, true);
            WriteLiteral(@"<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Price
            </th>
            <th>
                Make
            </th>
            <th>
                Model
            </th>
            <th>
                Option
            </th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 29 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(549, 46, true);
            WriteLiteral("        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(596, 9, false);
#line 33 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(605, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(658, 10, false);
#line 36 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(668, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(721, 14, false);
#line 39 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
           Write(item.Make.Name);

#line default
#line hidden
            EndContext();
            BeginContext(735, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(788, 15, false);
#line 42 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
           Write(item.Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(803, 54, true);
            WriteLiteral("\n            </th>\n            <th>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 857, "\"", 892, 2);
            WriteAttributeValue("", 864, "/smartphone/details/", 864, 20, true);
#line 45 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
WriteAttributeValue("", 884, item.Id, 884, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(893, 29, true);
            WriteLiteral(">Check</a>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 922, "\"", 958, 2);
            WriteAttributeValue("", 929, "/smartphone/editbyid/", 929, 21, true);
#line 46 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
WriteAttributeValue("", 950, item.Id, 950, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(959, 48, true);
            WriteLiteral(" class=\"btn-warning\">Edit</a>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1007, "\"", 1042, 2);
            WriteAttributeValue("", 1014, "/smartphone/destroy/", 1014, 20, true);
#line 47 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
WriteAttributeValue("", 1034, item.Id, 1034, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1043, 63, true);
            WriteLiteral(" class=\"btn-danger\">Delete</a>\n            </th>\n        </tr>\n");
            EndContext();
#line 50 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\CurrentUserAdvertisement.cshtml"
        }

#line default
#line hidden
            BeginContext(1116, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Advertisement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
