#pragma checksum "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07de256d4376598a1982308b7cc4a64a754366e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Edit), @"mvc.1.0.view", @"/Views/Professor/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07de256d4376598a1982308b7cc4a64a754366e9", @"/Views/Professor/Edit.cshtml")]
    public class Views_Professor_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartSchool.Models.Professor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Professor</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Registro"" class=""control-label""></label>
                <input asp-for=""Registro"" class=""form-control"" />
                <span asp-validation-for=""Registro"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Sobrenome"" class=""control-label""></label>
                <input asp-for=""Sobrenome"" class=""form-control"" />
                <span asp-validation-");
            WriteLiteral(@"for=""Sobrenome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Telefone"" class=""control-label""></label>
                <input asp-for=""Telefone"" class=""form-control"" />
                <span asp-validation-for=""Telefone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataInicial"" class=""control-label""></label>
                <input asp-for=""DataInicial"" class=""form-control"" />
                <span asp-validation-for=""DataInicial"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DataFim"" class=""control-label""></label>
                <input asp-for=""DataFim"" class=""form-control"" />
                <span asp-validation-for=""DataFim"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
              ");
            WriteLiteral("      <input class=\"form-check-input\" asp-for=\"Ativo\" /> ");
#nullable restore
#line 48 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Edit.cshtml"
                                                                  Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Projetos\Web\.NET Core & Angular\ProjectSmartSchool\SmartSchool\SmartSchool.API\Views\Professor\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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