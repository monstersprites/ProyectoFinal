#pragma checksum "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "904114ba284a17985d3e7a60efe355f9e1d7ae52"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregar_cliente")]
    public partial class AgregarCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a href=\"/gestion_clientes\"><img src=\"/imgs/arrow.png\"></a>\r\n\r\n<br>\r\n<br>\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Agregar cliente</h3>\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(2, "form");
            __builder.AddMarkupContent(3, "\r\n\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mb-3");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"txtcedula\" class=\"form-label\">Cédula</label>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "txtcedula");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                                                            cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.AddMarkupContent(16, "<button>Verificar</button>\r\n\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mb-3");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<label for=\"txtnombre\" class=\"form-label\">Nombre</label>\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "id", "txtnombre");
            __builder.AddAttribute(25, "disabled", true);
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                                                            nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombre = __value, nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "mb-3");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<label for=\"txtapellido\" class=\"form-label\">Apellido</label>\r\n        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control");
            __builder.AddAttribute(37, "id", "txtapellido");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                                                              apellido

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => apellido = __value, apellido));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "mb-3");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.AddMarkupContent(45, "<label for=\"txtnacionalidad\" class=\"form-label\">Nacionalidad</label>\r\n        ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "id", "txtnacionalidad");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                                                                  nacionalidad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nacionalidad = __value, nacionalidad));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "mb-3");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, "<label for=\"txtsangre\" class=\"form-label\">Tipo de sangre</label>\r\n        ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "id", "txtsangre");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                      tsangre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tsangre = __value, tsangre));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "null");
            __builder.AddAttribute(65, "selected", true);
            __builder.AddContent(66, "Seleccione el tipo de sangre");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "O negativo");
            __builder.AddContent(70, "O negativo");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "O positivo");
            __builder.AddContent(74, "O positivo");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "A negativo");
            __builder.AddContent(78, "A negativo");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "A positivo");
            __builder.AddContent(82, "A positivo");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "B negativo");
            __builder.AddContent(86, "B negativo");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "B positivo");
            __builder.AddContent(90, "B positivo");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "AB negativo");
            __builder.AddContent(94, "AB negativo");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "AB positivo");
            __builder.AddContent(98, "AB positivo");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n    ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "mb-3");
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.AddMarkupContent(105, "<label for=\"txtfotopersona\" class=\"form-label\">Foto de usted</label>\r\n        ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "type", "file");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "id", "txtfotopersona");
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                                                                 fotopersona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fotopersona = __value, fotopersona));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n    ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "mb-3");
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.AddMarkupContent(117, "<label for=\"txtfotolicencia\" class=\"form-label\">Foto de su licencia de conducir</label>\r\n        ");
            __builder.OpenElement(118, "input");
            __builder.AddAttribute(119, "type", "file");
            __builder.AddAttribute(120, "class", "form-control");
            __builder.AddAttribute(121, "id", "txtfotolicencia");
            __builder.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
                                                                                  fotolicencia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fotolicencia = __value, fotolicencia));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n\r\n    ");
            __builder.AddMarkupContent(126, "<button class=\"btn btn-primary\">Agregar</button>\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarCliente.razor"
           

        string cedula;
        string nombre;
        string apellido;
        string correo;
        string nacionalidad;
        string tsangre;
        string fotopersona;
        string fotolicencia;

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591