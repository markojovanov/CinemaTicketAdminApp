#pragma checksum "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc129b975264c3da6ffb7b309231a0d08dbf909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#line 1 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\_ViewImports.cshtml"
using CinemaTicketAdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\_ViewImports.cshtml"
using CinemaTicketAdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc129b975264c3da6ffb7b309231a0d08dbf909", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0b3ca52a08800a3762d52d84eaef99fd0942e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemaTicketAdminApp.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <p>\r\n        <a class=\"btn btn-success\">");
#nullable restore
#line 10 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
                              Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
     for (int i = 0; i < Model.TicketInOrders.Count(); i++)
    {
        var item = Model.TicketInOrders.ElementAt(i).SelectedTicket;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 20 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\r\n                <div class=\"card\" style=\"width: 18rem; height: 30rem;\">\r\n                    <img class=\"card-img-top\" style=\"height: 70%\"");
            BeginWriteAttribute("src", " src=\"", 602, "\"", 619, 1);
#nullable restore
#line 24 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
WriteAttributeValue("", 608, item.Image, 608, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                    <div class=\"card-body\">\r\n                        <h3>");
#nullable restore
#line 26 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 27 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"

            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 36 "C:\Users\Marko\Desktop\CinemaTicketAdminApp\Views\Order\Details.cshtml"
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemaTicketAdminApp.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
