#pragma checksum "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de9fddb821c50c72d96e57593d8486f7ff56626"
// <auto-generated/>
#pragma warning disable 1591
namespace SegundaEvaluacion.Client.Pages.Pais
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
    public partial class PaisFormulario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                 Pais

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                                      onValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "<label>C??digo</label>\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                                                          Pais.CodPais

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pais.CodPais = __value, Pais.CodPais))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Pais.CodPais));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __Blazor.SegundaEvaluacion.Client.Pages.Pais.PaisFormulario.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 7 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                                      () => Pais.CodPais

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Nombre del pa??s</label>\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                                                          Pais.NombrePais

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Pais.NombrePais = __value, Pais.NombrePais))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Pais.NombrePais));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.SegundaEvaluacion.Client.Pages.Pais.PaisFormulario.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 14 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                                      () => Pais.NombrePais

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.AddMarkupContent(32, "<button class=\"btn btn-primary\" type=\"submit\">Guardar</button>\r\n    ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "class", "btn btn-secondary");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
                                                onCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddContent(37, "Cancelar");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "F:\PROYECTOS\CARRERA\ModeladoParcial3\SegundaEvaluacion\Client\Pages\Pais\PaisFormulario.razor"
       
    [Parameter] public Pais Pais { get; set; }
    [Parameter] public EventCallback onValidSubmit { get; set; }
    [Parameter] public EventCallback onCancel { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SegundaEvaluacion.Client.Pages.Pais.PaisFormulario
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
