#pragma checksum "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9e9eadc553391b3e6a337728ab1a4b01f64c9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mintic.App.Presentacion.Pages.CrudGrupo.Pages_CrudGrupo_Index), @"mvc.1.0.razor-page", @"/Pages/CrudGrupo/Index.cshtml")]
namespace Mintic.App.Presentacion.Pages.CrudGrupo
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
#line 1 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\_ViewImports.cshtml"
using Mintic.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9e9eadc553391b3e6a337728ab1a4b01f64c9f", @"/Pages/CrudGrupo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce02ea12245c69b4166b7e89cb0b56d094f3ad5c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudGrupo_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
  
    ViewData["Title"] = "Grupos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
  body {
      background: url(""https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/Background.png?raw=true""); 
      background-size: 100;
	  background-repeat: no-repeat;
      background-position: center;
 }
 </style>

<div class=""container"">
    <img src=""https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/LogoUCaldas.png?raw=true""");
            BeginWriteAttribute("align", " align=\"", 507, "\"", 515, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"90\">\r\n    <img src=\"https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/LogoMintic.png?raw=true\"");
            BeginWriteAttribute("align", " align=\"", 654, "\"", 662, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"90\">\r\n    <img src=\"https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/Admin.png?raw=true\" align=\"right\" width=\"100\" height=\"90\">\r\n</div>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9e9eadc553391b3e6a337728ab1a4b01f64c9f5915", async() => {
                WriteLiteral("Crear un grupo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"panel-primary\">\r\n    <div class=\"panel-heading\"> <h4>Lista de grupos</h4></div>\r\n</div>\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead style=\"background-color: #CCCCCC\" align=\"center\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grupo[0].CodigoGrupo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Acciones</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody align=\"center\">\r\n");
#nullable restore
#line 38 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
 foreach (var item in Model.Grupo) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodigoGrupo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Formador.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Formador.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tutor.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.Tutor.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </td>
            <td>
                <div class=""dropdown"">
                    <button type=""button"" data-toggle=""dropdown"" class=""btn btn-primary dropdown-toggle"" aria-haspopup=""true"" aria-expanded=""true"">Ver mas <span class=""caret""></span></button>
                    <ul class=""dropdown-menu"" style=""position: relative;"">
                      <div class=""d-grid gap-2 col-6 mx-auto"">
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9e9eadc553391b3e6a337728ab1a4b01f64c9f10416", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9e9eadc553391b3e6a337728ab1a4b01f64c9f12652", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9e9eadc553391b3e6a337728ab1a4b01f64c9f14894", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                      </div>  \r\n                    </ul>\r\n                </div>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudGrupo\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table><br><br>
<div class=""container"" align=""center"">
    <img src=""https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/Facebook.png?raw=true"" align =""center"" width=""50"" height=""30"" hspace=""10"">
    <img src=""https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/Twitter.png?raw=true"" align=""center"" width=""50"" height=""30"" hspace=""10"">
    <img src=""https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/Youtube.png?raw=true"" align=""center"" width=""50"" height=""30"" hspace=""10"">
    <img src=""https://github.com/MarlonMena/ProyectoMintic/blob/main/Mintic.App/Iconos/Ayuda.png?raw=true"" align=""Right"" width=""50"" height=""30"">
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mintic.App.Presentacion.Pages.CrudGrupo.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mintic.App.Presentacion.Pages.CrudGrupo.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mintic.App.Presentacion.Pages.CrudGrupo.IndexModel>)PageContext?.ViewData;
        public Mintic.App.Presentacion.Pages.CrudGrupo.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
