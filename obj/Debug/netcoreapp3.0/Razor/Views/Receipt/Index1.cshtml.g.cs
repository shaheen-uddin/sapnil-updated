#pragma checksum "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66728702b88d5a4223cdc87b919b775732fa2ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receipt_Index1), @"mvc.1.0.view", @"/Views/Receipt/Index1.cshtml")]
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
#line 1 "/home/shaheen/Sapnil/Views/_ViewImports.cshtml"
using Sapnil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/shaheen/Sapnil/Views/_ViewImports.cshtml"
using Sapnil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66728702b88d5a4223cdc87b919b775732fa2ccb", @"/Views/Receipt/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1535a89e086fbd49e3f4dad64ccd9a1105ba61", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipt_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sapnil.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        \r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.InvoiceNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.CellNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.CellNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.InvoiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.InvoiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 50 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
         if(Model.Product.FrameName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 53 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.FrameName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 56 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.FrameName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 59 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.FrameQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 62 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.FrameQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 65 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.FramePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 68 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.FramePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 70 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
         if(Model.Product.PowerLense != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 74 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.PowerLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 77 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.PowerLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 80 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.PowerLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 83 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.PowerLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 86 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.PowerLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 89 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.PowerLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 91 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
        if(Model.Product.ContactLense !=null)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 95 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.ContactLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 98 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.ContactLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 101 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.ContactLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 104 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.ContactLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 107 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.ContactLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 110 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.ContactLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 112 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 114 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
        if(Model.Product.LeftEyeSph !=null)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 117 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.LeftEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 120 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.LeftEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 123 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.LeftEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 126 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.LeftEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 129 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.LeftEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 132 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.LeftEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-2\">\r\n                ");
#nullable restore
#line 135 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayNameFor(model => model.Product.LeftEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-10\">\r\n                ");
#nullable restore
#line 138 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
           Write(Html.DisplayFor(model => model.Product.LeftEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 140 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.RightEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Product.RightEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.RightEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Product.RightEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.RightEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Product.RightEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.RightEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Product.RightEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n        \r\n        \r\n        \r\n        \r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment.TotalAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Payment.TotalAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Payment.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment.NetAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Payment.NetAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment.PaidAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Payment.PaidAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </dd>\r\n         <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayNameFor(model => model.Payment.DueAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
       Write(Html.DisplayFor(model => model.Payment.DueAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 203 "/home/shaheen/Sapnil/Views/Receipt/Index1.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66728702b88d5a4223cdc87b919b775732fa2ccb22095", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sapnil.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591