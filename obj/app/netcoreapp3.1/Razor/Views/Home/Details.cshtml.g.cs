#pragma checksum "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfbe66126f4ddf6dba5f02fb010cdd154242862f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\_ViewImports.cshtml"
using Sapnil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\_ViewImports.cshtml"
using Sapnil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfbe66126f4ddf6dba5f02fb010cdd154242862f", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1535a89e086fbd49e3f4dad64ccd9a1105ba61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sapnil.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
 if(Model !=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"background-color:#e3e3e3;color: red;\">\r\n");
#nullable restore
#line 11 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
     if(Model.FrameName !=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p> Frame - Name : ");
#nullable restore
#line 13 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                    Write(Model.FrameName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Quantity : ");
#nullable restore
#line 13 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                 Write(Model.FrameQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Price: ");
#nullable restore
#line 13 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                         Write(Model.FramePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
     if(Model.PowerLense != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <p>Lense - Name: ");
#nullable restore
#line 17 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                 Write(Model.PowerLense);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Quantity : ");
#nullable restore
#line 17 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                               Write(Model.PowerLenseQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Price : ");
#nullable restore
#line 17 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                             Write(Model.PowerLensePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
     if(Model.ContactLense != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <p>Contact Lese - Color: ");
#nullable restore
#line 21 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                         Write(Model.ContactLense);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Quantity : ");
#nullable restore
#line 21 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                         Write(Model.ContactLenseQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Price : ");
#nullable restore
#line 21 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                                         Write(Model.ContactLensePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     <p>Right Eye : Sph : ");
#nullable restore
#line 23 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                     Write(Model.RightEyeSph);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Cyl: ");
#nullable restore
#line 23 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                              Write(Model.RightEyeCyl);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Axis: ");
#nullable restore
#line 23 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                        Write(Model.RightEyeAxis);

#line default
#line hidden
#nullable disable
            WriteLiteral(", N.Add: ");
#nullable restore
#line 23 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                                                    Write(Model.RightEyeAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n     <p>Left Eye : Sph : ");
#nullable restore
#line 24 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                    Write(Model.LeftEyeSph);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Cyl: ");
#nullable restore
#line 24 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                            Write(Model.LeftEyeCyl);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Axis: ");
#nullable restore
#line 24 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                     Write(Model.LeftEyeAxis);

#line default
#line hidden
#nullable disable
            WriteLiteral(", N.Add: ");
#nullable restore
#line 24 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                                                                                                Write(Model.LeftEyeAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
      if(Model.Ipd != null)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>IPD : ");
#nullable restore
#line 27 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
            Write(Model.Ipd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
     if(Model.FocalOption != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Focal Option: ");
#nullable restore
#line 31 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                    Write(Model.FocalOption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 32 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("     \r\n     <p>Delivery Status: ");
#nullable restore
#line 34 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"
                    Write(Model.DeliveryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
#nullable restore
#line 36 "C:\Users\shaheen\Music\Sapnil-8.2.1\Sapnil\Views\Home\Details.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sapnil.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
