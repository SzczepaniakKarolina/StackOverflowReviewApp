#pragma checksum "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d0520cd5db64a2eeb98df6302d0ad104ed8475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tags_Index), @"mvc.1.0.view", @"/Views/Tags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tags/Index.cshtml", typeof(AspNetCore.Views_Tags_Index))]
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
#line 1 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\_ViewImports.cshtml"
using StackoverflowReviewApp;

#line default
#line hidden
#line 2 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\_ViewImports.cshtml"
using StackoverflowReviewApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d0520cd5db64a2eeb98df6302d0ad104ed8475", @"/Views/Tags/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa26a609975c00f5783b57de2d3749e3f22e3075", @"/Views/_ViewImports.cshtml")]
    public class Views_Tags_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TagViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
  
    ViewData["Title"] = "Lista tagów";

#line default
#line hidden
            BeginContext(74, 110, true);
            WriteLiteral("\r\n<h2>Lista tagów</h2>\r\n<span>Lista prezentuje 1000 najpopularniejszych tagów z serwisu StackOverflow</span>\r\n");
            EndContext();
#line 8 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
            BeginContext(227, 273, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Nazwa</th>
                <th scope=""col"">Popularność</th>
                <th scope=""col"">Procentowa popularność</th>
            </tr>
        </thead>
        <tbody>

");
            EndContext();
#line 20 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
             foreach (var tag in Model)
            {

#line default
#line hidden
            BeginContext(556, 46, true);
            WriteLiteral("                <tr>\r\n                    <th>");
            EndContext();
            BeginContext(603, 8, false);
#line 23 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
                   Write(tag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(611, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(643, 9, false);
#line 24 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
                   Write(tag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(652, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(684, 11, false);
#line 25 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
                   Write(tag.Average);

#line default
#line hidden
            EndContext();
            BeginContext(695, 31, true);
            WriteLiteral("%</th>\r\n                </tr>\r\n");
            EndContext();
#line 27 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(741, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 30 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(785, 83, true);
            WriteLiteral("    <div class=\"alert alert-info\" role=\"alert\">\r\n        Brak wyników\r\n    </div>\r\n");
            EndContext();
#line 36 "C:\Users\Karolina\Documents\Repository\StackoverflowReviewApp\StackoverflowReviewApp\Views\Tags\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TagViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
