#pragma checksum "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b26e73e704b64c47993c15b3c357de00c19982ff"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/habilitar_cliente")]
    public partial class HabilitarCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a href=\"/gestion_clientes\"><img src=\"/imgs/arrow.png\"></a>\n\n<br>\n<br>\n<br>\n\n");
            __builder.AddMarkupContent(1, "<h3>Habilitar cliente</h3>\n\n<hr>\n\n<label for=\"txtcedula\"></label>\n");
            __builder.OpenElement(2, "select");
            __builder.AddAttribute(3, "id", "txtcedula");
            __builder.AddAttribute(4, "class", "form-select");
            __builder.AddAttribute(5, "aria-label", "Default select example");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
                                                                                      cedula_cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula_cliente = __value, cedula_cliente));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "selected");
            __builder.AddContent(10, "Seleccione un cliente");
            __builder.CloseElement();
#nullable restore
#line 16 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
     foreach (var c in lista_cliente)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 18 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
                        c.IDENTIFICATION

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, 
#nullable restore
#line 18 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
                                           c.IDENTIFICATION

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n<br>\n<br>\n<br>\n\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-info");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
                                       habilitarCliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Habilitar");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/HabilitarCliente.razor"
       

    [Inject]
    public IJSRuntime JS { get; set; }

    string cedula_cliente;

    List<Cliente> lista_cliente = new List<Cliente>();

    protected override async Task OnInitializedAsync()
    {

        String API = $"https://pruebasv4.herokuapp.com/AllClient";

        WebClient cliente = new WebClient();

        var datos = cliente.DownloadString(API);

        lista_cliente = JsonConvert.DeserializeObject<List<Cliente>>(datos);

    }

    public async Task habilitarCliente()
    {

        var http = new HttpClient();

        var cliente = new Cliente
        {

        };

        var jsonBody = JsonConvert.SerializeObject(cliente);
        var buffer = Encoding.UTF8.GetBytes(jsonBody);
        var byteContent = new ByteArrayContent(buffer);
        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await http.PostAsync("https://pruebasv4.herokuapp.com/enableClient/" + cedula_cliente, byteContent);

        var content = await response.Content.ReadAsStringAsync();

        var json = JsonConvert.DeserializeObject(content);

        await JS.InvokeVoidAsync("alert", json);

    }

    public class Cliente
    {

        public string IDENTIFICATION { get; set; }

        public string FIRSTNAME { get; set; }

        public string LASTNAME { get; set; }

        public string EMAIL { get; set; }

        public string LICENSE { get; set; }

        public string NATIONALITY { get; set; }

        public string BLOODTYPE { get; set; }

        public string PHOTOPERSON { get; set; }

        public string PHOTOLICENSE { get; set; }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
