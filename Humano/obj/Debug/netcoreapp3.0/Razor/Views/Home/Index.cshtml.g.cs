#pragma checksum "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7dc593ec10d59fe15c44881731fef70b459ead5"
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
#line 1 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\_ViewImports.cshtml"
using Humano;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\_ViewImports.cshtml"
using Humano.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7dc593ec10d59fe15c44881731fef70b459ead5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61026d2ced15737fe970e4a8ff4175e1bf64d985", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Humano.Models.Checada>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Checadas</h1>\r\n        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 11 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Hora checada\r\n                </th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 22 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.checada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\3073395.UAG\Documents\UAG\Octavo\Bases de datos II\Proyecto final\Humano\Humano\Views\Home\Index.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Humano.Models.Checada>> Html { get; private set; }
    }
}
#pragma warning restore 1591
