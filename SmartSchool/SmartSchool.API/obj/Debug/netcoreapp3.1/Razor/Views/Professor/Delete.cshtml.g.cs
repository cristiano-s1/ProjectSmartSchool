#pragma checksum "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd657b6bfd77d6969f5e4fd57b88121ff2fc34d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Delete), @"mvc.1.0.view", @"/Views/Professor/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd657b6bfd77d6969f5e4fd57b88121ff2fc34d", @"/Views/Professor/Delete.cshtml")]
    public class Views_Professor_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSchool.Models.Professor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Professor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Registro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataInicial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataInicial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DataFim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartSchool.Models.Professor> Html { get; private set; }
    }
}
#pragma warning restore 1591