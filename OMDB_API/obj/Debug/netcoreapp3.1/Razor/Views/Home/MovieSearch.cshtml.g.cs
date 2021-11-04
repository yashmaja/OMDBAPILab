#pragma checksum "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035ddb63fe8c434265da10fe71f70b6fb138e206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieSearch), @"mvc.1.0.view", @"/Views/Home/MovieSearch.cshtml")]
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
#line 1 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\_ViewImports.cshtml"
using OMDB_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\_ViewImports.cshtml"
using OMDB_API.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035ddb63fe8c434265da10fe71f70b6fb138e206", @"/Views/Home/MovieSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a61644806c302716b82d5640c08f2ee8d4b36f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035ddb63fe8c434265da10fe71f70b6fb138e2063817", async() => {
                WriteLiteral("\r\n    <label for=\"title\">Search movie by title: </label>\r\n    <input size=\"70\" type=\"text\" id=\"title\" name=\"title\" placeholder=\"Enter title keyword(s)\" />\r\n    <input type=\"submit\" value=\"Search\" /><br /><br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <h5>Movies that match your search: </h5>\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 658, "\"", 677, 1);
#nullable restore
#line 22 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
WriteAttributeValue("", 664, Model.Poster, 664, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 678, "\"", 709, 3);
#nullable restore
#line 22 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
WriteAttributeValue("", 684, Model.Title, 684, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 696, "Movie", 697, 6, true);
            WriteAttributeValue(" ", 702, "Poster", 703, 7, true);
            EndWriteAttribute();
            WriteLiteral(" width=\"160\" height=\"250\" />\r\n        </div>\r\n        <div class=\"col-sm-8\">\r\n            <h4>");
#nullable restore
#line 25 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 25 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
                         Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 25 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
                                      Write(Model.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h6>");
#nullable restore
#line 26 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
           Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p>");
#nullable restore
#line 27 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
          Write(Model.Plot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\yashi\source\repos\OMDB_API\OMDB_API\Views\Home\MovieSearch.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591