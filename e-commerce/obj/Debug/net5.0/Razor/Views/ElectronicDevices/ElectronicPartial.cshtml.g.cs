#pragma checksum "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3164b251bcf809c08dbbb14db02d8af8d9c3604b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ElectronicDevices_ElectronicPartial), @"mvc.1.0.view", @"/Views/ElectronicDevices/ElectronicPartial.cshtml")]
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
#line 1 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\_ViewImports.cshtml"
using e_commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\_ViewImports.cshtml"
using e_commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3164b251bcf809c08dbbb14db02d8af8d9c3604b", @"/Views/ElectronicDevices/ElectronicPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89f65dd6894ee13e717bed8c15fd34f1952c3ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ElectronicDevices_ElectronicPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<e_commerce.Models.ElectronicDevice>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ElectronicDevices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3164b251bcf809c08dbbb14db02d8af8d9c3604b4327", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"row overflow-auto\">\r\n");
#nullable restore
#line 7 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 overflow-auto\">\r\n\r\n\r\n\r\n            <div class=\"card\">\r\n\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3164b251bcf809c08dbbb14db02d8af8d9c3604b6173", async() => {
                WriteLiteral(" <img");
                BeginWriteAttribute("src", " src=\"", 416, "\"", 437, 1);
#nullable restore
#line 17 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
WriteAttributeValue("", 422, item.ImageFile, 422, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height:200px\" class=\"card-img-top overflow-auto\" alt=\"...\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
                                                                             WriteLiteral(item.EId);

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
            WriteLiteral("\r\n\r\n                <div class=\"card-body\">\r\n\r\n                    <h5 class=\"card-title\">\r\n\r\n                        <b>");
#nullable restore
#line 23 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
                      Write(item.EName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n                        <span class=\"bg-success\" style=\"color:white\">\r\n\r\n                            ");
#nullable restore
#line 27 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
                       Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <span class=\"glyphicon glyphicon-star\"></span>\r\n\r\n                        </span>\r\n\r\n                    </h5>\r\n\r\n                    <h5 class=\"card-title\">Rs ");
#nullable restore
#line 35 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <s>Rs. 250 </s> 20% <span class=\"glyphicon glyphicon-exclamation-sign\" style=\"color:red\"></span></h5>\r\n\r\n                    <br>\r\n\r\n                    <p class=\"card-text\">");
#nullable restore
#line 39 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n                </div>\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n            <br />\r\n\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\bhargava.koya\Desktop\C#\Project\ECommerceproject\FullCartWithWebAPIIntegration\e-commerce\e-commerce\Views\ElectronicDevices\ElectronicPartial.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<e_commerce.Models.ElectronicDevice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
