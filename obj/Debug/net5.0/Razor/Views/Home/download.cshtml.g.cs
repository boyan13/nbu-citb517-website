#pragma checksum "V:\Projects\Source Dev\local\Academic and work\University\nbu\Web\CITB517\vs2019\CITB517-WebApplication\Views\Home\download.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5ae96d415a666f12901d6d280fc219e74d88d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_download), @"mvc.1.0.view", @"/Views/Home/download.cshtml")]
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
#line 1 "V:\Projects\Source Dev\local\Academic and work\University\nbu\Web\CITB517\vs2019\CITB517-WebApplication\Views\_ViewImports.cshtml"
using CITB517_WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "V:\Projects\Source Dev\local\Academic and work\University\nbu\Web\CITB517\vs2019\CITB517-WebApplication\Views\_ViewImports.cshtml"
using CITB517_WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5ae96d415a666f12901d6d280fc219e74d88d3", @"/Views/Home/download.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb13e9d94e2aa7dabfa2a89ca358d6e390200d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_download : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "V:\Projects\Source Dev\local\Academic and work\University\nbu\Web\CITB517\vs2019\CITB517-WebApplication\Views\Home\download.cshtml"
  
    Layout = null;
    var img = @Url.Content("~" + "/img/gallery/gallery" + ViewBag.id + ".jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5ae96d415a666f12901d6d280fc219e74d88d33763", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"" />
    <title>Boyan Bonev</title>
    <style>
        body {
            background: #a8a8a8;
            background: linear-gradient(150deg, rgba(223,223,223,1) 0%, rgba(175,175,175,1) 100%);
            background-attachment: fixed;
        }

        img {
            display: block;
            margin: 0 auto;
            max-width: 1080px;
            height: auto;
        }

        #download {
            border: 1px solid #ccc;
            text-decoration: none;
            text-align: center;
            color: black;
            background-color: white;
            padding-top: 5px;
            margin: 15px;
            position: fixed;
            width: 150px;
            height: 30px;
        }

        #download:hover {
            border-color: #777;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b5ae96d415a666f12901d6d280fc219e74d88d35594", async() => {
                WriteLiteral("\r\n    <a id=\"download\" target=\"_self\"");
                BeginWriteAttribute("href", " href=\"", 1071, "\"", 1082, 1);
#nullable restore
#line 48 "V:\Projects\Source Dev\local\Academic and work\University\nbu\Web\CITB517\vs2019\CITB517-WebApplication\Views\Home\download.cshtml"
WriteAttributeValue("", 1078, img, 1078, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" download>Download</a>\r\n    <img id=\"image\" style=\"display: block;\"");
                BeginWriteAttribute("src", " src=\"", 1150, "\"", 1160, 1);
#nullable restore
#line 49 "V:\Projects\Source Dev\local\Academic and work\University\nbu\Web\CITB517\vs2019\CITB517-WebApplication\Views\Home\download.cshtml"
WriteAttributeValue("", 1156, img, 1156, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
