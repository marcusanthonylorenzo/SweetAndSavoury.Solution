#pragma checksum "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b033318a371c9a4b1aeb8fc853657c2067156015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b033318a371c9a4b1aeb8fc853657c2067156015", @"/Views/Account/Index.cshtml")]
    #nullable restore
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text columnized\">\r\n\r\n      <h3>You\'ve logged in as: ");
#nullable restore
#line 9 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h3>\r\n\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"spaceyboi-badNamingConvention\" style=\"height: 3vh;\"></div>\r\n");
            WriteLiteral("    <button class=\"btn acc\">");
#nullable restore
#line 19 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn acc\">");
#nullable restore
#line 20 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Add a new flavour", "Create", "Flavours"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn acc\">");
#nullable restore
#line 21 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Add a new treat", "Create", "Treats"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 22 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Register or Login</h2>\r\n    <hr />\r\n");
            WriteLiteral("    <div class=\"spaceyboi-badNamingConvention\" style=\"height: 3vh;\"></div>\r\n");
            WriteLiteral("    <button class=\"btn acc\">");
#nullable restore
#line 31 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn acc\">");
#nullable restore
#line 32 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Log in", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n    <button class=\"btn acc\">");
#nullable restore
#line 33 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 34 "C:\Users\Marcus\desktop\SweetAndSavoury.Solution\Patisserie\Views\Account\Index.cshtml"
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
