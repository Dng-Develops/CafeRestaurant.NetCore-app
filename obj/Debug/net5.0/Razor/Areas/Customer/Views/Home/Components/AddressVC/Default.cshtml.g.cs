#pragma checksum "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\Home\Components\AddressVC\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8b73f7dc75936870880c430dcabd2e1b84c837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Components_AddressVC_Default), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Components/AddressVC/Default.cshtml")]
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
#line 1 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\_ViewImports.cshtml"
using CafeRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\_ViewImports.cshtml"
using CafeRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8b73f7dc75936870880c430dcabd2e1b84c837", @"/Areas/Customer/Views/Home/Components/AddressVC/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41dd05f83b3a9127a3429724f40da0ef4375e1a3", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Components_AddressVC_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CafeRestaurant.Models.Address>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\Home\Components\AddressVC\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"m-b-40\">\r\n        <li class=\"txt14 m-b-14\">\r\n            <i class=\"fa fa-map-marker fs-16 dis-inline-block size19\" aria-hidden=\"true\"></i>\r\n            ");
#nullable restore
#line 7 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\Home\Components\AddressVC\Default.cshtml"
       Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n\r\n        <li class=\"txt14 m-b-14\">\r\n            <i class=\"fa fa-phone fs-16 dis-inline-block size19\" aria-hidden=\"true\"></i>\r\n            ");
#nullable restore
#line 12 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\Home\Components\AddressVC\Default.cshtml"
       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n\r\n        <li class=\"txt14 m-b-14\">\r\n            <i class=\"fa fa-envelope fs-13 dis-inline-block size19\" aria-hidden=\"true\"></i>\r\n            ");
#nullable restore
#line 17 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\Home\Components\AddressVC\Default.cshtml"
       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
#nullable restore
#line 20 "C:\Users\Hz.Ord.Prof.Dr.Deniz\Desktop\Web Uygulamalar\_Portfolio\CafeRestaurant\Areas\Customer\Views\Home\Components\AddressVC\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CafeRestaurant.Models.Address>> Html { get; private set; }
    }
}
#pragma warning restore 1591
