#pragma checksum "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d209fb4877d574e393582248d809bcf5801e6dae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mintic.App.Presentacion.Pages.CrudPersona.Pages_CrudPersona_Details), @"mvc.1.0.razor-page", @"/Pages/CrudPersona/Details.cshtml")]
namespace Mintic.App.Presentacion.Pages.CrudPersona
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d209fb4877d574e393582248d809bcf5801e6dae", @"/Pages/CrudPersona/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce02ea12245c69b4166b7e89cb0b56d094f3ad5c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudPersona_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Persona</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Fijo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Fijo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Persona.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
       Write(Html.DisplayFor(model => model.Persona.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d209fb4877d574e393582248d809bcf5801e6dae13801", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\ProyectosMintic\RepositorioProyectoFinal\ProyectoMintic\Mintic.App\Mintic.App.Presentacion\Pages\CrudPersona\Details.cshtml"
                           WriteLiteral(Model.Persona.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d209fb4877d574e393582248d809bcf5801e6dae15997", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mintic.App.Presentacion.Pages.CrudPersona.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mintic.App.Presentacion.Pages.CrudPersona.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mintic.App.Presentacion.Pages.CrudPersona.DetailsModel>)PageContext?.ViewData;
        public Mintic.App.Presentacion.Pages.CrudPersona.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
