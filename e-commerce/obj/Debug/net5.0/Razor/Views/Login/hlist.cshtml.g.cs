#pragma checksum "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc1f894029c02187bfc0127f5ceae689152c1afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_hlist), @"mvc.1.0.view", @"/Views/Login/hlist.cshtml")]
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
#line 1 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\_ViewImports.cshtml"
using e_commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\_ViewImports.cshtml"
using e_commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc1f894029c02187bfc0127f5ceae689152c1afe", @"/Views/Login/hlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89f65dd6894ee13e717bed8c15fd34f1952c3ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_hlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<e_commerce.Models.HomeDecor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
  
    ViewData["Title"] = "hlist";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>hlist</h2>\r\n\r\n<div>\r\n    <h4>HomeDecor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.HName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.HName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.HType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 24 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.HType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 27 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 39 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 45 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 48 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 51 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.HBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 54 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.HBrand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 57 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 60 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.ImageFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 63 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.FreeDelivery));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.FreeDelivery));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 69 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.LaunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 72 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.LaunchDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 75 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 78 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1f894029c02187bfc0127f5ceae689152c1afe11663", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\Login\hlist.cshtml"
                           WriteLiteral(Model.HId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1f894029c02187bfc0127f5ceae689152c1afe13844", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_commerce.Models.HomeDecor> Html { get; private set; }
    }
}
#pragma warning restore 1591
