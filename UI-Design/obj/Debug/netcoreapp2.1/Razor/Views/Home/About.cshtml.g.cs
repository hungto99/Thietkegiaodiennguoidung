#pragma checksum "C:\Users\Hung\source\repos\UI-Design\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f40c1cc68e944c4e6a02a7553e14fddea9cfd3"
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
#line 1 "C:\Users\Hung\source\repos\UI-Design\Views\_ViewImports.cshtml"
using UI_Design;

#line default
#line hidden
#line 2 "C:\Users\Hung\source\repos\UI-Design\Views\_ViewImports.cshtml"
using UI_Design.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f40c1cc68e944c4e6a02a7553e14fddea9cfd3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bdc8b01df6c5c9489da196f7376b85918a1da79", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                BeginContext(14, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 25, "\"", 62, 1);
#line 2 "C:\Users\Hung\source\repos\UI-Design\Views\Home\About.cshtml"
WriteAttributeValue("", 32, Url.Content("~/css/PSD7.css"), 32, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(63, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 94, "\"", 134, 1);
#line 3 "C:\Users\Hung\source\repos\UI-Design\Views\Home\About.cshtml"
WriteAttributeValue("", 101, Url.Content("~/css/ourmenu.css"), 101, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(135, 31, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 166, "\"", 207, 1);
#line 4 "C:\Users\Hung\source\repos\UI-Design\Views\Home\About.cshtml"
WriteAttributeValue("", 173, Url.Content("~/css/location.css"), 173, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(208, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(251, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 264, "\"", 301, 1);
#line 7 "C:\Users\Hung\source\repos\UI-Design\Views\Home\About.cshtml"
WriteAttributeValue("", 270, Url.Content("~/js/ourmenu.js"), 270, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(302, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 325, "\"", 359, 1);
#line 8 "C:\Users\Hung\source\repos\UI-Design\Views\Home\About.cshtml"
WriteAttributeValue("", 331, Url.Content("~/js/PSD7.js"), 331, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(360, 143, true);
                WriteLiteral("></script>\r\n    <script>\r\n        $(\'#home\').removeClass(\'border--custom\');\r\n        $(\'#ourmenu\').addClass(\'border--custom\');\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(506, 1154, true);
            WriteLiteral(@"<div class=""intro-slider slide1 intro_slider--custom1"">
    <div>LOCATION</div>
    <div class=""alt_slide"">HOME <span> > </span>LOCATION</div>
</div>
<div class=""warp_infor"">
    <div class=""infor_fishhouse"">
        <div class=""infor_background"">
        </div>
        <div class=""warp_greeting"">
            <div class=""greeting"">
                LOCATION 1
            </div>
            <div class=""infor_content row b4:jumbotron"">
                <div class=""col-lg-6 contact"">
                    <div>
                        <h3>PHONE</h3>
                        800-123-1234
                    </div>
                    <div>
                        <h3>LOCATION</h3>
                        123, New Lenox,</br>
                        Chicago, IL 60606
                    </div>
                    <div>
                        <h3>HOURS</h3>
                        <span>M-F</span> 11am-2am</br>
                        <span>Sa</span> 10am-3am</br>
                        <spa");
            WriteLiteral("n>Su</span> 10am-2am\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
