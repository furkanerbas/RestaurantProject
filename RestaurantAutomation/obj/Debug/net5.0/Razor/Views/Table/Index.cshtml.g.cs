#pragma checksum "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef2b4b9ff41244436252abf17bba6cbe4bee883"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Table_Index), @"mvc.1.0.view", @"/Views/Table/Index.cshtml")]
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
#line 1 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\_ViewImports.cshtml"
using RestaurantAutomation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\_ViewImports.cshtml"
using RestaurantAutomation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef2b4b9ff41244436252abf17bba6cbe4bee883", @"/Views/Table/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0ecdef81bf670ebe075b17b5c3a8dca92959665", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Table_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
#nullable restore
#line 9 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml"
     foreach (Table table in ViewBag.tables)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4 col-sm-12\">\r\n    <div class=\"card h-100\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml"
                              Write(table.TableId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 374, "\"", 406, 2);
            WriteAttributeValue("", 381, "/Order/Add/", 381, 11, true);
#nullable restore
#line 16 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml"
WriteAttributeValue("", 392, table.TableId, 392, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\">+</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 456, "\"", 496, 2);
            WriteAttributeValue("", 463, "/Order/TableOrders/", 463, 19, true);
#nullable restore
#line 17 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml"
WriteAttributeValue("", 482, table.TableId, 482, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\">Listele</a>\r\n    </div>\r\n</div>");
#nullable restore
#line 19 "C:\Users\303FURKAN_AKSAM\Desktop\RestaurantProject\RestaurantAutomation\Views\Table\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
