#pragma checksum "C:\Users\hp 840 g3\source\repos\Movie\Movie\Views\Home\Training.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a4de4bc72da9262d5329be456748c38ef57deb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Training), @"mvc.1.0.view", @"/Views/Home/Training.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Training.cshtml", typeof(AspNetCore.Views_Home_Training))]
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
#line 1 "C:\Users\hp 840 g3\source\repos\Movie\Movie\_ViewImports.cshtml"
using Movie.Models;

#line default
#line hidden
#line 2 "C:\Users\hp 840 g3\source\repos\Movie\Movie\_ViewImports.cshtml"
using Movie.Models.RestModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a4de4bc72da9262d5329be456748c38ef57deb4", @"/Views/Home/Training.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcb674d5cc62978c9e71e55f89742a4e8790ac5", @"/_ViewImports.cshtml")]
    public class Views_Home_Training : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6748875f874ced9240586e21992ad8", async() => {
                BeginContext(31, 1321, true);
                WriteLiteral(@"
    <style>
        .box {
            position: relative;
            width: 600px;
            height: 300px;
            margin: 100px auto 0 auto;
        }

        .box-gradient {
            position: absolute;
            width: 100%;
            height: 100%;
            border-radius: 10px;
            -moz-border-radius: 10px;
            -webkit-border-radius: 10px;
            background: -moz-linear-gradient(left, #CCCCCC 0%, #EEEEEE 50%, #EEEEEE 50%, #CCCCCC 100%);
            background: -webkit-gradient(linear, left top, right top, color-stop(0%,#CCCCCC),color-stop(50%,#EEEEEE), color-stop(50%,#EEEEEE), color-stop(100%,#CCCCCC));
        }

        .box-shadow {
            position: absolute;
            left: 50%;
            margin: 400px 0 0 -290px;
            bottom: 10px;
            width: 580px;
            height: 16px;
            background: #fff;
            border-radius: 290px / 8px;
            -moz-border-radius: 290px / 8px;
            -webkit");
                WriteLiteral(@"-border-radius: 290px / 8px;
            box-shadow: 0 10px 20px #000;
            -moz-box-shadow: 0 10px 20px #000;
            -webkit-box-shadow: 0 10px 20px #000;
        }
    </style>
    <title>CSS 3D Box Test</title>
    <link rel=""stylesheet"" href=""style.css"" type=""text/css"" />
");
                EndContext();
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
            EndContext();
            BeginContext(1359, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1363, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a1278d6e0c46a68101e5904172db20", async() => {
                BeginContext(1369, 173, true);
                WriteLiteral("\r\n    <div class=\"box\">\r\n        <div class=\"box-shadow\"></div>\r\n        <div class=\"box-gradient\">\r\n            ...some content can go here...\r\n        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1549, 9, true);
            WriteLiteral("\r\n</html>");
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