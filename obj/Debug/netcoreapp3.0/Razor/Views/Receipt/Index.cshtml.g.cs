#pragma checksum "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94af4542d8f2c77cf18a323d82a4e72b1e3f1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receipt_Index), @"mvc.1.0.view", @"/Views/Receipt/Index.cshtml")]
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
#line 1 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/_ViewImports.cshtml"
using Sapnil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/_ViewImports.cshtml"
using Sapnil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94af4542d8f2c77cf18a323d82a4e72b1e3f1dc", @"/Views/Receipt/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1535a89e086fbd49e3f4dad64ccd9a1105ba61", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipt_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sapnil.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <p class=\"text-right px-3 printCopy\"> Customer\'s Copy</p>\r\n    \r\n    <div class=\"row px-5 m-3\">\r\n        \r\n        <div class = \"col-md-4\">\r\n            <dl class=\"row border\">\r\n                <dd class=\"col\" >\r\n                ");
#nullable restore
#line 17 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 21 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.InvoiceNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"w-100\"></div>\r\n                \r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 26 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 29 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div> <!-- 1st column -->\r\n        <div class=\"col-md-4\">\r\n            <dl class=\"row border\">\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 36 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CellNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 39 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.CellNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"w-100\"></div>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 43 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 46 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div> <!--2nd column -->\r\n        <div class=\"col-md-4\">\r\n            <dl class=\"row border\">\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 53 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.InvoiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 56 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.InvoiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"w-100\"></div>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 60 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 63 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>
            </dl>
        </div> <!--3rd Column-->
    </div> <!-- row -->
    <div class=""row px-5 m-3"">
        
    <table class=""table-bordered "">
        <thead class=""border"">
            <th class=""px-5 border""> Product </th>
            <th class=""px-5 border"">Quantity</th>
            <th class=""px-5 border""> Price</th>
        </thead>
");
#nullable restore
#line 76 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
         if(Model.Product.FrameName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.FrameName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 84 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.FrameQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 88 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.FramePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
         if(Model.Product.PowerLense != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.PowerLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 100 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.PowerLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 104 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.PowerLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 107 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
        if(Model.Product.ContactLense !=null)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 112 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.ContactLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 116 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.ContactLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 120 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.ContactLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 123 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
   
    </div> <!-- row -->
    <div class=""row px-5 m-3"">
         <table class=""table-bordered "">
        <thead class=""border"">
            <th class=""px-5 border""> Eye </th>
            <th class=""px-5 border""> Sph </th>
            <th class=""px-5 border"">Cyl</th>
            <th class=""px-5 border""> Axis</th>
            <th class=""px-5 border""> N.Add</th>
        </thead>
      
         
      
           <tr>
               <td> Right </td>
                    <td>
                        ");
#nullable restore
#line 142 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 146 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 150 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 154 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n            <tr>\r\n            <tr> \r\n               <td> Left</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 160 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n           \r\n                <td>\r\n                    ");
#nullable restore
#line 164 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 168 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 172 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </td>
            </tr>
        </table>
        
    </div> <!-- row -->    
        
    <div class=""row px-5 m-3"">
        
            <div class=""col-md-4 p-4 offset-md-2"">
                <h3 class=""border text-center d-inline-block rounded-circle ml-5 p-4"">
");
#nullable restore
#line 183 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                      
                        var paid = "PAID";
                        var due = "DUE";
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                     if(Model.Payment.DueAmount == null || Model.Payment.DueAmount == 0) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                                                                                     Write(paid);

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                                                                                               ;} 
                    else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                      Write(due);

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                                ;}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                 </h3>\r\n            </div>\r\n            <table class=\"table-bordered col-md-6 \">\r\n                <tr>\r\n                    <td>Total Amount</td>\r\n                    <td> ");
#nullable restore
#line 196 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.TotalAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Discount </td>\r\n                    <td> ");
#nullable restore
#line 200 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Net Amount</td>\r\n                    <td> ");
#nullable restore
#line 204 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.NetAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Paid Amount</td>\r\n                    <td> ");
#nullable restore
#line 208 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.PaidAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                  <tr>\r\n                    <td>Due Amount</td>\r\n                    <td> ");
#nullable restore
#line 212 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.DueAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>


            </table>
       

    </div> <!--row-->
    <div class=""row  px-5 m-3"">
        <div class=""col-md-12 p3-4 mt-4"">
            <p class=""text-right border-top ML"">Authorized Signature</p>
        </div>
    </div> <!--row-->
    <p class=""text-center p"">Thanks for purchase. Please, come again. </p> 
           <div class=""row fix"">
              <p class="" col-md-12 text-center border-top py-2 dev"">Developed by shaheen uddin, Phone: 01721505978. All Right Reserved by Author.</p>
          </div>
</div>
<hr>
        <div class=""container bg pt-1 shadow bg-white rounded receipt-hack"">
            <div class=""row mx-5 px-3 "">
            <div class=""col-md-2 text-center "">
                <img src=""/images/sign.jpg"" class="" rounded-circle d-inline-block pt-1 logo"" ");
            WriteLiteral(@"/>
            </div>
            <div class=""col-md-9"">
                <h1 class=""pt-3  text-center name text-danger"">স্বপ্নীল অপটিকস্</h1>
                <h5 class=""text-center gf "">৪৯, জিগাতলা, ধানমন্ডি, ঢাকা-১২০৯</h5>
                <h6 class=""text-center"">Cell: 01712841584, Phone : 9615923 </h6>


            </div>
            </div> <!--row-->

        </div><!--container -->
         <p class=""text-right px-3 printCopy""> Dealer's Copy</p>
<div>
    
    
    <div class=""row px-5 m-3"">
        
        <div class = ""col-md-4"">
            <dl class=""row border"">
                <dd class=""col"" >
                ");
#nullable restore
#line 255 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 258 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.InvoiceNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"w-100\"></div>\r\n                \r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 263 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 266 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div> <!-- 1st column -->\r\n        <div class=\"col-md-4\">\r\n            <dl class=\"row border\">\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 273 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CellNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 276 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.CellNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"w-100\"></div>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 280 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 283 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div> <!--2nd column -->\r\n        <div class=\"col-md-4\">\r\n            <dl class=\"row border\">\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 290 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.InvoiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 293 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.InvoiceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"w-100\"></div>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 297 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd><span class=\"d-inline-block float-right\">:</span>\r\n                <dd class=\"col\">\r\n                    ");
#nullable restore
#line 300 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </dd>
            </dl>
        </div> <!--3rd Column-->
    </div> <!-- row -->
    <div class=""row px-5 m-3"">
        
    <table class=""table-bordered "">
        <thead class=""border"">
            <th class=""px-5 border""> Product </th>
            <th class=""px-5 border""> Quantity</th>
            <th class=""px-5 border""> Price</th>
        </thead>
");
#nullable restore
#line 313 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
         if(Model.Product.FrameName != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 317 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.FrameName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 321 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.FrameQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 325 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.FramePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 328 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 329 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
         if(Model.Product.PowerLense != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 333 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.PowerLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 337 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.PowerLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 341 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.PowerLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 344 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 345 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
        if(Model.Product.ContactLense !=null)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 349 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.ContactLense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 353 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.ContactLenseQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 357 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.ContactLensePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 360 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
   
    </div> <!-- row -->
    <div class=""row px-5 m-3"">
         <table class=""table-bordered "">
        <thead class=""border"">
            <th class=""px-5 border""> Eye </th>
            <th class=""px-5 border""> Sph </th>
            <th class=""px-5 border"">Cyl</th>
            <th class=""px-5 border""> Axis</th>
            <th class=""px-5 border""> N.Add</th>
        </thead>
      
           <tr> 
               <td> Left</td>
                <td>
                    ");
#nullable restore
#line 377 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n           \r\n                <td>\r\n                    ");
#nullable restore
#line 381 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                \r\n                <td>\r\n                    ");
#nullable restore
#line 385 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            \r\n                <td>\r\n                    ");
#nullable restore
#line 389 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
               Write(Html.DisplayFor(model => model.Product.LeftEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n      \r\n           <tr>\r\n               <td> Right </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 396 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeSph));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 400 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeCyl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 404 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeAxis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                \r\n                    <td>\r\n                        ");
#nullable restore
#line 408 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                   Write(Html.DisplayFor(model => model.Product.RightEyeAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </td>
            <tr>
        </table>
        
    </div> <!-- row -->    
        
    <div class=""row px-5 m-3"">
            <div class=""col-md-4 p-4 offset-md-2"">
                <h3 class=""border text-center d-inline-block rounded-circle ml-5 p-4"">
");
#nullable restore
#line 420 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                     if(Model.Payment.DueAmount == null || Model.Payment.DueAmount == 0) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 420 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                                                                                     Write(paid);

#line default
#line hidden
#nullable disable
#nullable restore
#line 420 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                                                                                               ;} 
                    else { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 421 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                      Write(due);

#line default
#line hidden
#nullable disable
#nullable restore
#line 421 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                                ;}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                   \r\n                 </h3>\r\n            </div>\r\n        \r\n            <table class=\"table-bordered col-md-6 \">\r\n                <tr>\r\n                    <td>Total Amount</td>\r\n                    <td> ");
#nullable restore
#line 431 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.TotalAmmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Discount </td>\r\n                    <td> ");
#nullable restore
#line 435 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.DiscountAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Net Amount</td>\r\n                    <td> ");
#nullable restore
#line 439 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.NetAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Paid Amount</td>\r\n                    <td> ");
#nullable restore
#line 443 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.PaidAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                  <tr>\r\n                    <td>Due Amount</td>\r\n                    <td> ");
#nullable restore
#line 447 "/home/shaheen/SANIL/Sapnil-8.2.1/Sapnil/Views/Receipt/Index.cshtml"
                    Write(Html.DisplayFor(model => model.Payment.DueAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>


            </table>
       

    </div> <!--row-->
        <div class=""row  px-5 m-3"">
        <div class=""col-md-12 pt-3 mt-4"">
            <p class=""text-right border-top ML"">Authorized Signature</p>
        </div>
    </div> <!--row-->
          <p class=""text-center p"">Thanks for purchase. Please, come again.</p> 
          <div class=""row fix"">
              <p class="" col-md-12 text-center border-top py-2 dev"">Developed by shaheen uddin, Cell: 01721505978. All Right Reserved by Author.</p>
          </div>
</div>
");
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
