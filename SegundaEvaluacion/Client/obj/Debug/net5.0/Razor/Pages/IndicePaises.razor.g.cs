#pragma checksum "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68f6c13c7d5235d9eb192f4770badc51139a0fa4"
// <auto-generated/>
#pragma warning disable 1591
namespace SegundaEvaluacion.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/paises")]
    public partial class IndicePaises : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Paises</h2>\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<a class=\"btn btn-primary\" href=\"paises/crear\">Nuevo</a>\r\n<br>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddMarkupContent(3, "<tr><th>Código</th>\r\n        <th>Nombre</th></tr>");
#nullable restore
#line 11 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
     if (paises == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<tr>Cargando.....</tr>");
#nullable restore
#line 14 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
    }
    else if (paises.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<tr>No existen paises</tr>");
#nullable restore
#line 18 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
         foreach (var item in paises)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 24 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                     item.CodPais

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 25 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                     item.NombrePais

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "btn btn-success");
            __builder.AddAttribute(16, "href", "paises/editar/" + (
#nullable restore
#line 28 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 28 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                                                     item.CodPais

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 28 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                                                                   item.NombrePais

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n                        Editar\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-warning");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                                                              ()=>Eliminar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenComponent<SegundaEvaluacion.Client.Shared.Confirmacion>(25);
            __builder.AddAttribute(26, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 39 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                         GrabarEliminar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 40 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                        Cancelar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(28, "Titulo", "BORRAR");
            __builder.AddAttribute(29, "textCancelar", "Salir");
            __builder.AddAttribute(30, "textOk", "Aceptar");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(32, "div");
                __builder2.AddMarkupContent(33, "¿Desea eliminar el país ");
                __builder2.AddContent(34, 
#nullable restore
#line 44 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                                  eliminarPais.NombrePais

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(35, "?");
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 38 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
                    confirmacion = (SegundaEvaluacion.Client.Shared.Confirmacion)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\IndicePaises.razor"
       
    List<SegundaEvaluacion.Shared.Datos.Entidades.Pais> paises;
    Confirmacion confirmacion;
    string codPais = "";
    string nomPais = "";
    SegundaEvaluacion.Shared.Datos.Entidades.Pais eliminarPais;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        paises = new()
        {
                new SegundaEvaluacion.Shared.Datos.Entidades.Pais()
                { CodPais = "at", NombrePais = "Atlantis" },
                new SegundaEvaluacion.Shared.Datos.Entidades.Pais()
                { CodPais = "es", NombrePais = "Esparta" }
            };
    }

    private void Eliminar(SegundaEvaluacion.Shared.Datos.Entidades.Pais paisEliminar)
    {
        confirmacion.Mostrar();
        codPais = paisEliminar.CodPais;
        nomPais = paisEliminar.NombrePais;
        eliminarPais = paisEliminar;
    }


    private void GrabarEliminar()
    {
        paises.Remove(eliminarPais);
        Cancelar();
    }

    private void Cancelar()
    {
        confirmacion.Ocultar();
        eliminarPais = null;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591