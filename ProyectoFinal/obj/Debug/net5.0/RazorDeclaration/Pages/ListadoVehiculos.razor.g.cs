// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListadoVehiculos")]
    public partial class ListadoVehiculos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "/home/elmer/Desktop/tareas_de_p3/ProyectoFinal/ProyectoFinal/Pages/ListadoVehiculos.razor"
       

    DateTime fecha_inicio;

    DateTime fecha_final;

    List<Vehicle> resultados = new List<Vehicle>();

    public void buscarVehiculos()
    {
        string fecha1 = fecha_inicio.ToString();

        string fecha2 = fecha_final.ToString();

        String API = $"https://pruebasv4.herokuapp.com/avaibleVehicles/{fecha1}/{fecha2}";

        WebClient cliente = new WebClient();

        var datos1 = cliente.DownloadString(API);

        resultados = JsonConvert.DeserializeObject<List<Vehicle>>(datos1);

    }


    public class Vehicle
    {

        public string BRAND { get; set; }

        public string MODEL { get; set; }

        public int YEAR { get; set; }

        public string COLOUR { get; set; }

        public double PRICEPERDAY { get; set; }

        public string TYPE { get; set; }

        public string LOADCAPACITY { get; set; }

        public int PASSENGERS { get; set; }

        public string Enrollment { get; set; }

        public string INSURANCE_NO { get; set; }

        public string PHOTO { get; set; }

        public string LATITUDE { get; set; }

        public string LONGITUDE { get; set; }

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
