#pragma checksum "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eed0d7df9371bf14dcf4781370a97ced993c175"
// <auto-generated/>
#pragma warning disable 1591
namespace SegundaEvaluacion.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using SegundaEvaluacion.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using SegundaEvaluacion.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using SegundaEvaluacion.Client.Pages.Pais;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using SegundaEvaluacion.Client.Pages.Persona;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using SegundaEvaluacion.Shared.Datos.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\_Imports.razor"
using SegundaEvaluacion.Client.Servicios;

#line default
#line hidden
#nullable disable
    public partial class Confirmacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
 if (MostrarConfirmacion)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddAttribute(8, "style", "display: block;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-content");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-header");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "modal-title");
            __builder.AddAttribute(18, "id", "exampleModalLabel");
            __builder.AddContent(19, 
#nullable restore
#line 10 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                                                                    Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                                      onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "class", "close");
            __builder.AddAttribute(25, "data-dismiss", "modal");
            __builder.AddAttribute(26, "aria-label", "Close");
            __builder.AddMarkupContent(27, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-body");
            __builder.AddContent(31, 
#nullable restore
#line 17 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "modal-footer");
#nullable restore
#line 20 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                     if (verCancelar)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                                          onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "class", "btn btn-secondary");
            __builder.AddAttribute(39, "data-dismiss", "modal");
            __builder.AddContent(40, 
#nullable restore
#line 24 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                             textCancelar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 25 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                                 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                     if (verOk)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                                          onConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddContent(45, 
#nullable restore
#line 29 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                             textOk

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 31 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
          }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Shared\Confirmacion.razor"
       
    private bool MostrarConfirmacion = false;
    [Parameter] public bool verCancelar { get; set; } = true;
    [Parameter] public bool verOk { get; set; } = true;
    [Parameter] public string textCancelar { get; set; } = "Cancelar";
    [Parameter] public string textOk { get; set; } = "Ok";
    [Parameter] public string Titulo { get; set; } = "Confirmación";
    [Parameter] public EventCallback onConfirm { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }

    public void Mostrar() => MostrarConfirmacion = true;

    public void Ocultar() => MostrarConfirmacion = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
