#pragma checksum "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a98fb894895949b5c411be1673e3e8aa702294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Index), @"mvc.1.0.view", @"/Views/Professor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73a98fb894895949b5c411be1673e3e8aa702294", @"/Views/Professor/Index.cshtml")]
    public class Views_Professor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartSchool.Models.Professor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataInicial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataInicial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataFim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1767, "\"", 1790, 1);
#nullable restore
#line 64 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
WriteAttributeValue("", 1782, item.Id, 1782, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1843, "\"", 1866, 1);
#nullable restore
#line 65 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
WriteAttributeValue("", 1858, item.Id, 1858, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1921, "\"", 1944, 1);
#nullable restore
#line 66 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
WriteAttributeValue("", 1936, item.Id, 1936, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartSchool.Models.Professor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
