#pragma checksum "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4605155c5f2c33049293bc5f6a31bbf5815465be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Models_Info), @"mvc.1.0.view", @"/Views/Models/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Models/Info.cshtml", typeof(AspNetCore.Views_Models_Info))]
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
#line 1 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\_ViewImports.cshtml"
using TheShop.Models;

#line default
#line hidden
#line 2 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\_ViewImports.cshtml"
using TheShop.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4605155c5f2c33049293bc5f6a31bbf5815465be", @"/Views/Models/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0bf655f51e429e0a5cbf8a3496f6efe7d4296b", @"/Views/_ViewImports.cshtml")]
    public class Views_Models_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Motocykl>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wallpap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No picutre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(17, 46, true);
            WriteLiteral("\r\n<div class=\"main\">\r\n    <div class=\"scroll\">");
            EndContext();
            BeginContext(63, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "639550082e994438b240b4335bf9f23e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 89, "~/images/", 89, 9, true);
#line 4 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
AddHtmlAttributeValue("", 98, Model.Wallpaper, 98, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(134, 84, true);
            WriteLiteral("<a href=\"#down\"><span></span>Scroll</a></div>\r\n\r\n    <div class=\"wp1\">\r\n        <h2>");
            EndContext();
            BeginContext(219, 11, false);
#line 7 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
       Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(230, 331, true);
            WriteLiteral(@"</h2>
    </div>

    <div class=""w2"">
    </div>

    <div id=""down"" class=""main-container"">

        <input type=""radio"" id=""i1"" name=""images"" checked />
        <input type=""radio"" id=""i2"" name=""images"" />
        <input type=""radio"" id=""i3"" name=""images"" />

        <div class=""slide_img"" id=""one"">

            ");
            EndContext();
            BeginContext(561, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4da7861f027d4cf8b845265ef7653c69", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 571, "~/images/", 571, 9, true);
#line 21 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
AddHtmlAttributeValue("", 580, Model.Pic1, 580, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(610, 224, true);
            WriteLiteral("\r\n\r\n            <label class=\"prev\" for=\"i3\"><span>&#x2039;</span></label>\r\n            <label class=\"next\" for=\"i2\"><span>&#x203a;</span></label>\r\n\r\n        </div>\r\n\r\n        <div class=\"slide_img\" id=\"two\">\r\n\r\n            ");
            EndContext();
            BeginContext(834, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1c7c39a26900403689a14e9d940a53f3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 844, "~/images/", 844, 9, true);
#line 30 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
AddHtmlAttributeValue("", 853, Model.Pic2, 853, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(883, 224, true);
            WriteLiteral("\r\n\r\n            <label class=\"prev\" for=\"i1\"><span>&#x2039;</span></label>\r\n            <label class=\"next\" for=\"i3\"><span>&#x203a;</span></label>\r\n\r\n        </div>\r\n\r\n        <div class=\"slide_img\" id=\"three\">\r\n            ");
            EndContext();
            BeginContext(1107, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56ae4503c8dd4297b74fcbc92958d508", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1117, "~/images/", 1117, 9, true);
#line 38 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
AddHtmlAttributeValue("", 1126, Model.Pic3, 1126, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1156, 664, true);
            WriteLiteral(@" 

            <label class=""prev"" for=""i2""><span>&#x2039;</span></label>
            <label class=""next"" for=""i1""><span>&#x203a;</span></label>
        </div>



        <div id=""nav_slide"">
            <label for=""i1"" class=""dots"" id=""dot1""></label>
            <label for=""i2"" class=""dots"" id=""dot2""></label>
            <label for=""i3"" class=""dots"" id=""dot3""></label>
        </div>

    </div>
    <div class=""text-box"">

        <div class=""description-box"">
            <div class=""slide-info"" id=""si1"">
                <h1 class=""slide-h1""></h1>
                <h2 class=""slide-h2"">About</h2>
                <p>
                    ");
            EndContext();
            BeginContext(1821, 10, false);
#line 60 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
               Write(Model.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 312, true);
            WriteLiteral(@"
                </p>
                <h2 class=""slide-h2"">More</h2>
            </div>
            <div class=""slide-specification"">
                <ul class=""specification-ul"">
                    <li class=""specification-li"">
                        <label>Year</label>
                        <span>");
            EndContext();
            BeginContext(2144, 18, false);
#line 68 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
                         Write(Model.RokProdukcji);

#line default
#line hidden
            EndContext();
            BeginContext(2162, 170, true);
            WriteLiteral("</span>\r\n                    </li>\r\n                    <li class=\"specification-li\">\r\n                        <label>Manufacturer</label>\r\n                        <span>");
            EndContext();
            BeginContext(2333, 11, false);
#line 72 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
                         Write(Model.Marka);

#line default
#line hidden
            EndContext();
            BeginContext(2344, 163, true);
            WriteLiteral("</span>\r\n                    </li>\r\n                    <li class=\"specification-li\">\r\n                        <label>Model</label>\r\n                        <span>");
            EndContext();
            BeginContext(2508, 11, false);
#line 76 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
                         Write(Model.Model);

#line default
#line hidden
            EndContext();
            BeginContext(2519, 150, true);
            WriteLiteral("</span>\r\n                    <li class=\"specification-li\">\r\n                        <label>Engine displacement</label>\r\n                        <span>");
            EndContext();
            BeginContext(2670, 15, false);
#line 79 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
                         Write(Model.Pojemnosc);

#line default
#line hidden
            EndContext();
            BeginContext(2685, 169, true);
            WriteLiteral("</span>\r\n                    </li>\r\n                    <li class=\"specification-li\">\r\n                        <label>Engine Type</label>\r\n                        <span>");
            EndContext();
            BeginContext(2855, 19, false);
#line 83 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
                         Write(Model.RodzajSilnika);

#line default
#line hidden
            EndContext();
            BeginContext(2874, 163, true);
            WriteLiteral("</span>\r\n                    </li>\r\n                    <li class=\"specification-li\">\r\n                        <label>Power</label>\r\n                        <span>");
            EndContext();
            BeginContext(3038, 9, false);
#line 87 "C:\Users\helio\source\repos\Web-App\TheShop\TheShop\Views\Models\Info.cshtml"
                         Write(Model.Moc);

#line default
#line hidden
            EndContext();
            BeginContext(3047, 589, true);
            WriteLiteral(@"</span>
                    </li>
                </ul>
            </div>
        </div>
    </div>

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script>
$(document).ready(function(){
  
  $(""a"").on('click', function(event) {
    if (this.hash !== """") {
      event.preventDefault();

      var hash = this.hash;

      $('html, body').animate({
        scrollTop: $(hash).offset().top
      }, 800, function(){

        window.location.hash = hash;
      });
    }
  });
});
    </script>

    <hr>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Motocykl> Html { get; private set; }
    }
}
#pragma warning restore 1591