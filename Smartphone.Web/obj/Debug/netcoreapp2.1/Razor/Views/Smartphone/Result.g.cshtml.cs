#pragma checksum "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74552afd50a48eab691d1eae2fe03dba6a6d39e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Smartphone_Result), @"mvc.1.0.view", @"/Views/Smartphone/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Smartphone/Result.cshtml", typeof(AspNetCore.Views_Smartphone_Result))]
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
#line 1 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
using Smartphone.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74552afd50a48eab691d1eae2fe03dba6a6d39e", @"/Views/Smartphone/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de015ee87a5b2d18f6b83caa68e79075cd02c7ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Smartphone_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Telephone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
  
    ViewData["Title"] = "MySmartphones";

#line default
#line hidden
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(143, 28, true);
            WriteLiteral("    <h1>nqma namereni</h1>\r\n");
            EndContext();
#line 11 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
}
else
{


#line default
#line hidden
            BeginContext(185, 430, true);
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
#line 38 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(664, 64, true);
            WriteLiteral("            <tr>\r\n\r\n                <th>\r\n\r\n                    ");
            EndContext();
            BeginContext(729, 24, false);
#line 44 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
               Write(item.NameOfAdvertisement);

#line default
#line hidden
            EndContext();
            BeginContext(753, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(821, 10, false);
#line 47 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(831, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(899, 20, false);
#line 50 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
               Write(item.Make.NameOfMake);

#line default
#line hidden
            EndContext();
            BeginContext(919, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(987, 22, false);
#line 53 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
               Write(item.Model.NameOfModel);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 71, true);
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1080, "\"", 1115, 2);
            WriteAttributeValue("", 1087, "/smartphone/details/", 1087, 20, true);
#line 57 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
WriteAttributeValue("", 1107, item.Id, 1107, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1116, 54, true);
            WriteLiteral(">Check</a>\r\n                </th>\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
        }

#line default
#line hidden
            BeginContext(1181, 26, true);
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n");
            EndContext();
#line 64 "C:\Users\adida\source\repos\Smartphone.Web\Smartphone.Web\Views\Smartphone\Result.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Telephone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
