#pragma checksum "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709353ff8c343efec0f9cae6474762eaaa709f30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Smartphone_Details), @"mvc.1.0.view", @"/Views/Smartphone/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Smartphone/Details.cshtml", typeof(AspNetCore.Views_Smartphone_Details))]
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
#line 1 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
using Smartphone.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709353ff8c343efec0f9cae6474762eaaa709f30", @"/Views/Smartphone/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef859d2b78e35f5098f25bf23f45f75871183312", @"/Views/_ViewImports.cshtml")]
    public class Views_Smartphone_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Advertisement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(92, 11, true);
            WriteLiteral("<h1>Name - ");
            EndContext();
            BeginContext(104, 10, false);
#line 7 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(114, 18, true);
            WriteLiteral("</h1>\n<h2>Price - ");
            EndContext();
            BeginContext(133, 11, false);
#line 8 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
       Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(144, 32, true);
            WriteLiteral("</h2>\n<h3>Description:</h3>\n<h4>");
            EndContext();
            BeginContext(177, 17, false);
#line 10 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(194, 23, true);
            WriteLiteral("</h4>\n<h5>Model Year - ");
            EndContext();
            BeginContext(218, 21, false);
#line 11 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
            Write(Model.Model.ModelYear);

#line default
#line hidden
            EndContext();
            BeginContext(239, 16, true);
            WriteLiteral("</h5>\n<h5>Ram - ");
            EndContext();
            BeginContext(256, 15, false);
#line 12 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
     Write(Model.Model.RAM);

#line default
#line hidden
            EndContext();
            BeginContext(271, 22, true);
            WriteLiteral(" GB</h5>\n<h5>Memory - ");
            EndContext();
            BeginContext(294, 18, false);
#line 13 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
        Write(Model.Model.Memory);

#line default
#line hidden
            EndContext();
            BeginContext(312, 27, true);
            WriteLiteral(" GB</h5>\n<h5>Back Camera - ");
            EndContext();
            BeginContext(340, 23, false);
#line 14 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
             Write(Model.Model.BasicCamera);

#line default
#line hidden
            EndContext();
            BeginContext(363, 7, true);
            WriteLiteral("</h5>\n\n");
            EndContext();
#line 16 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
 if (Model.Image1 == true)
{

#line default
#line hidden
            BeginContext(399, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(403, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45ebc8ee450b496892fd86a8a4aba8e0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 7, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 413, "~/files/", 413, 8, true);
#line 18 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
AddHtmlAttributeValue("", 421, Model.UserId, 421, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 434, "/", 434, 1, true);
#line 18 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
AddHtmlAttributeValue("", 435, Model.MakeId, 435, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 448, "/", 448, 1, true);
#line 18 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
AddHtmlAttributeValue("", 449, Model.ModelId, 449, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 463, "/1.jpg", 463, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(497, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 19 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
}

#line default
#line hidden
#line 20 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
 if (Model.Image2 == true)
{

#line default
#line hidden
            BeginContext(529, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(533, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4065f44787e746728f3dbe926af5174d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 7, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 543, "~/files/", 543, 8, true);
#line 22 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
AddHtmlAttributeValue("", 551, Model.UserId, 551, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 564, "/", 564, 1, true);
#line 22 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
AddHtmlAttributeValue("", 565, Model.MakeId, 565, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 578, "/", 578, 1, true);
#line 22 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
AddHtmlAttributeValue("", 579, Model.ModelId, 579, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 593, "/2.jpg", 593, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(627, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 23 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
}

#line default
#line hidden
            BeginContext(630, 29, true);
            WriteLiteral("\n<h1>Contact:</h1>\n<div>\n    ");
            EndContext();
            BeginContext(660, 20, false);
#line 27 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(680, 6, true);
            WriteLiteral(" \n    ");
            EndContext();
            BeginContext(687, 19, false);
#line 28 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(706, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(712, 22, false);
#line 29 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
Write(Model.User.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(734, 7, true);
            WriteLiteral("\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 741, "\"", 773, 2);
            WriteAttributeValue("", 748, "/user/index/", 748, 12, true);
#line 30 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
WriteAttributeValue("", 760, Model.UserId, 760, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(774, 19, true);
            WriteLiteral(" >Check profile of ");
            EndContext();
            BeginContext(794, 19, false);
#line 30 "C:\Users\adida\OneDrive\Работен плот\Smartphone-master\Smartphone.Web\Views\Smartphone\Details.cshtml"
                                                     Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(813, 14, true);
            WriteLiteral("</a>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Advertisement> Html { get; private set; }
    }
}
#pragma warning restore 1591
