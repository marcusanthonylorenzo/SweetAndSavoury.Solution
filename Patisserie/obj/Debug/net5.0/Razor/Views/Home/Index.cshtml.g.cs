#pragma checksum "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "005347df4836ab7f97e3528eb1b299fdc0870993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 11 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
using Patisserie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"005347df4836ab7f97e3528eb1b299fdc0870993", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"log-off-section\">\r\n        <p>You\'re logged in as: ");
#nullable restore
#line 17 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
         using (Html.BeginForm("LogOff", "Account"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" class=\"btn btn-default\" value=\"Log out\" />\r\n");
#nullable restore
#line 22 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n");
            WriteLiteral("    <h2>View Flavours</h2>\r\n");
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 28 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
         foreach(Flavour flavour in ViewBag.Flavours)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 30 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
           Write(Html.ActionLink($"{flavour.Name}", "Details", "Flavours", new { id = flavour.FlavourId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 31 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 33 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"


    //create two side-by-side lists to view all flavours and treats together


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 37 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
  Write(Html.ActionLink("Add a new flavour", "Create", "Flavours"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 38 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"


}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Please log-in or register to continue.</h1>\r\n");
            WriteLiteral("    <div class=\"spaceyboi-badNamingConvention\" style=\"height: 3vh;\"></div>\r\n");
            WriteLiteral("    <p>");
#nullable restore
#line 48 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
  Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 49 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
  Write(Html.ActionLink("Log in", "Login", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "C:\Users\Marcus\Desktop\SweetAndSavoury.Solution\Patisserie\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
