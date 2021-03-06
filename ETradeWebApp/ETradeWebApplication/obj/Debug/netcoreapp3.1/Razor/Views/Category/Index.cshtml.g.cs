#pragma checksum "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3999d91694edf1f88ff7a52fac47fcd44f5b75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\_ViewImports.cshtml"
using ETradeWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\_ViewImports.cshtml"
using ETradeWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3999d91694edf1f88ff7a52fac47fcd44f5b75f", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76cff856764ecab60be225f017d587fc56ea88be", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n");
#nullable restore
#line 10 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
     foreach (var category in Model.Categories)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
           Write(category.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 348, "\"", 403, 2);
            WriteAttributeValue("", 355, "/category/delete?categoryId=", 355, 28, true);
#nullable restore
#line 16 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
WriteAttributeValue("", 383, category.CategoryId, 383, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alert-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 461, "\"", 516, 2);
            WriteAttributeValue("", 468, "/category/update?categoryId=", 468, 28, true);
#nullable restore
#line 17 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
WriteAttributeValue("", 496, category.CategoryId, 496, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"alert-warning\">Update</a></td>\r\n        </tr>    \r\n");
#nullable restore
#line 19 "D:\C# .Net Core Web Applications\ETradeWebApp\ETradeWebApplication\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/category/add\" class=\"alert alert-success\">Add New Category</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
