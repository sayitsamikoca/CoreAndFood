#pragma checksum "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6849c31440b4f6af93113b0d4bbcf3efc5adf7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGet), @"mvc.1.0.view", @"/Views/Category/CategoryGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6849c31440b4f6af93113b0d4bbcf3efc5adf7a3", @"/Views/Category/CategoryGet.cshtml")]
    #nullable restore
    public class Views_Category_CategoryGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
  
    ViewData["Title"] = "CategoryGet";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Category Add Page</h2>\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
 using(Html.BeginForm("CategoryAdd", "Category", FormMethod.Post))
{
    // 1-Action Name  2-ControllerName 3- Action ne zaman tetiklenecek.


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>İD</h4>\r\n");
#nullable restore
#line 16 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryID , new {@class = "form form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Category Name</h4>\r\n");
#nullable restore
#line 19 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName , new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.ValidationMessageFor(x => x.CategoryName , "" , new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Category Description</h4>\r\n");
#nullable restore
#line 24 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription , new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-warning\">Save Changes</button>\r\n");
#nullable restore
#line 28 "C:\Users\sayit\source\repos\CoreAndFood\CoreAndFood\Views\Category\CategoryGet.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
