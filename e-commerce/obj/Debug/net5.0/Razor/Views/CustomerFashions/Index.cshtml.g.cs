#pragma checksum "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2437f0535063c41ca38db8020abfa79db15eb960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerFashions_Index), @"mvc.1.0.view", @"/Views/CustomerFashions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2437f0535063c41ca38db8020abfa79db15eb960", @"/Views/CustomerFashions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89f65dd6894ee13e717bed8c15fd34f1952c3ba", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerFashions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<e_commerce.Models.Fashion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CustomerFashions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetFashion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/CustomerViewPartial.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2437f0535063c41ca38db8020abfa79db15eb9605512", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">

    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <title>Fashion</title>



    <!-- Bootstrap -->

    <link href=""Bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

    <link rel=""stylesheet"" href=https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css>

    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">

    <script src=https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js></script>

    <script src=https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js></script>

    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">





    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING:");
                WriteLiteral(@" Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>

      <script src=https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js></script>

      <script src=https://oss.maxcdn.com/respond/1.4.2/respond.min.js></script>

    <![endif]-->

    <style>

        .i-plain:hover {
            color: red
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2437f0535063c41ca38db8020abfa79db15eb9607933", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"container-fluid padding\">\r\n\r\n        <h2>Fashion Products</h2>\r\n\r\n        <br />\r\n\r\n        <div class=\"row overflow-auto\">\r\n");
#nullable restore
#line 73 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""col-md-3 overflow-auto"">



                    <div class=""card h-100"" style=""background-image: url('https://media.istockphoto.com/vectors/crepe-paper-textured-grunge-vector-tricolour-faded-background-with-vector-id1264073605?k=6&m=1264073605&s=612x612&w=0&h=P31yF3S7XWPIvIINd5uTfuwl1MUa0nqzTRRaG0mFay4='); backdrop-filter: blur(50px); background-size:cover; background-repeat: no-repeat;"">


                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2437f0535063c41ca38db8020abfa79db15eb9609125", async() => {
                    WriteLiteral(" <img");
                    BeginWriteAttribute("src", " src=\"", 2354, "\"", 2375, 1);
#nullable restore
#line 83 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
WriteAttributeValue("", 2360, item.ImageFile, 2360, 15, false);

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
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
                                                                                    WriteLiteral(item.FId);

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
                WriteLiteral("\r\n\r\n                        <div class=\"card-body\">\r\n\r\n                            <h5 class=\"card-title\">\r\n\r\n                                <b>");
#nullable restore
#line 89 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
                              Write(item.FName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n\r\n                                <span class=\"bg-success\" style=\"color:white\">\r\n\r\n                                    ");
#nullable restore
#line 93 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
                               Write(item.Rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                    <span class=\"glyphicon glyphicon-star\"></span>\r\n\r\n                                </span>\r\n\r\n                            </h5>\r\n\r\n                            <h5 class=\"card-title\">Rs ");
#nullable restore
#line 101 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <s>Rs. 250 </s> 20% <span class=\"glyphicon glyphicon-exclamation-sign\" style=\"color:red\"></span></h5>\r\n\r\n                            <br>\r\n\r\n                            <p class=\"card-text\">");
#nullable restore
#line 105 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
                                            Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <div class=\"view overlay\">\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2437f0535063c41ca38db8020abfa79db15eb96014254", async() => {
                    WriteLiteral("<span class=\"glyphicon glyphicon-shopping-cart\"></span>Add to Cart");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"
                                                                                    WriteLiteral(item.FId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <a href=\"#\" style=\"text-align:right\"");
                BeginWriteAttribute("class", " class=\"", 3522, "\"", 3530, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"glyphicon glyphicon-heart-empty i-plain\"></span></a>\r\n\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                    </div>\r\n                    <br />\r\n\r\n                </div>\r\n");
#nullable restore
#line 125 "C:\Users\bhargava.koya\Desktop\C#\Ecommerceproject\FullCartWithWebAPIIntegration\e-commerce\Views\CustomerFashions\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>

    </div>





    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->

    <script src=https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js></script>



    <!-- Include all compiled plugins (below), or include individual files as needed -->

    <script src=""Bootstrap/js/bootstrap.min.js""></script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<e_commerce.Models.Fashion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
