#pragma checksum "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/Products/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1bb56c20203e78ed0e563c3bc25beb6201b4179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/_ViewImports.cshtml"
using Shopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/_ViewImports.cshtml"
using Shopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1bb56c20203e78ed0e563c3bc25beb6201b4179", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7853487c17c32e4ef3e16982fe5673c0e86b7bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/Products/Details.cshtml"
  
    var p = (ProductModel)ViewData["foundProduct"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-deck\">\n        <div class=\"card text-center\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 136, "\"", 150, 1);
#nullable restore
#line 6 "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/Products/Details.cshtml"
WriteAttributeValue("", 142, p.Image, 142, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            <h6>");
#nullable restore
#line 7 "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/Products/Details.cshtml"
           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n            <p>");
#nullable restore
#line 8 "/Users/hanans/Desktop/Tuwaiq/lessons/WEEK5/shopping_mvc/Shopping/Shopping/Views/Products/Details.cshtml"
          Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n</div>");
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
