#pragma checksum "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86a1fbb3d4f61a7d28716de76a464634bc9c298"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 13 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/agregar_vehiculo")]
    public partial class AgregarVehiculo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a href=\"/gestion_vehiculos\"><img src=\"/imgs/arrow.png\"></a>\r\n\r\n<br>\r\n<br>\r\n<br>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2>Agregar vehiculo</h2>\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(2, "form");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mb-3");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"txtmarca\" class=\"form-label\">Marca</label>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "txtmarca");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                           marca

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => marca = __value, marca));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "mb-3");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<label for=\"txtmodelo\" class=\"form-label\">Modelo</label>\r\n        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "id", "txtmodelo");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                            modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => modelo = __value, modelo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "mb-3");
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.AddMarkupContent(31, "<label for=\"txtaño\" class=\"form-label\">Año</label>\r\n        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "number");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "id", "txtaño");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                           año

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => año = __value, año, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "mb-3");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.AddMarkupContent(43, "<label for=\"txtcolor\" class=\"form-label\">Color</label>\r\n        ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "id", "txtcolor");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                           color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => color = __value, color));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "mb-3");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.AddMarkupContent(55, "<label for=\"txtprecio\" class=\"form-label\">Precio por día(RD$)</label>\r\n        ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "number");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "id", "txtprecio");
            __builder.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                              precio

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => precio = __value, precio, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "custom-select");
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.AddMarkupContent(67, "<label>Tipo:</label>\r\n        ");
            __builder.OpenElement(68, "select");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                       tipo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tipo = __value, tipo));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "Carro");
            __builder.AddContent(74, "Carro");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "Camioneta");
            __builder.AddContent(78, "Camioneta");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "Camión");
            __builder.AddMarkupContent(82, "Camión");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "Motocicleta");
            __builder.AddContent(86, "Motocicleta");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "mb-3");
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.AddMarkupContent(93, "<label for=\"txtcapacidad\" class=\"form-label\">Capacidad de carga(Kg)</label>\r\n        ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "number");
            __builder.AddAttribute(96, "class", "form-control");
            __builder.AddAttribute(97, "id", "txtcapacidad");
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                                 capacidad

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => capacidad = __value, capacidad, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\r\n    ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "mb-3");
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.AddMarkupContent(105, "<label for=\"txtpasajeros\" class=\"form-label\">Pasajeros</label>\r\n        ");
            __builder.AddContent(106, 
#nullable restore
#line 63 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
         pasajeros

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "type", "range");
            __builder.AddAttribute(110, "class", "form-control");
            __builder.AddAttribute(111, "id", "txtpasajeros");
            __builder.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                                pasajeros

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => pasajeros = __value, pasajeros));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n    ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "mb-3");
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.AddMarkupContent(119, "<label for=\"txtmatricula\" class=\"form-label\">Matricula</label>\r\n        ");
            __builder.OpenElement(120, "input");
            __builder.AddAttribute(121, "type", "text");
            __builder.AddAttribute(122, "class", "form-control");
            __builder.AddAttribute(123, "id", "txtmatricula");
            __builder.AddAttribute(124, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                               matricula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => matricula = __value, matricula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n    ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "mb-3");
            __builder.AddMarkupContent(130, "\r\n        ");
            __builder.AddMarkupContent(131, "<label for=\"txtseguro\" class=\"form-label\">Número de seguro</label>\r\n        ");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "type", "number");
            __builder.AddAttribute(134, "class", "form-control");
            __builder.AddAttribute(135, "id", "txtseguro");
            __builder.AddAttribute(136, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                              seguro

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(137, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => seguro = __value, seguro, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n\r\n    ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "mb-3");
            __builder.AddMarkupContent(142, "\r\n        ");
            __builder.AddMarkupContent(143, "<label for=\"txtfoto\" class=\"form-label\">Foto</label>\r\n        ");
            __builder.OpenElement(144, "input");
            __builder.AddAttribute(145, "type", "file");
            __builder.AddAttribute(146, "class", "form-control");
            __builder.AddAttribute(147, "id", "txtfoto");
            __builder.AddAttribute(148, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                                                          foto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => foto = __value, foto));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n\r\n\r\n    ");
            __builder.OpenElement(152, "button");
            __builder.AddAttribute(153, "class", "btn btn-primary");
            __builder.AddAttribute(154, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
                                              ApiRest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(155, "Agregar");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Daniel Lora\Desktop\Blazor's Apps\ProyectoFinal\Pages\AgregarVehiculo.razor"
       

    string marca;
    string modelo;
    int año;
    string color;
    int precio;
    string tipo;
    int capacidad;
    int pasajeros;
    string matricula;
    long seguro;
    string foto;



    public void addVehicle()
    {
        string API = "https://pruebasv4.herokuapp.com/registervehicle";

        Vehicle nuevo_vehiculo = new Vehicle();

        nuevo_vehiculo.BRAND = marca;
        nuevo_vehiculo.MODEL = modelo;
        nuevo_vehiculo.YEAR = año;
        nuevo_vehiculo.COLOUR = color;
        nuevo_vehiculo.PRICEPERDAY = precio;
        nuevo_vehiculo.TYPE = tipo;
        nuevo_vehiculo.LOADCAPACITY = capacidad.ToString();
        nuevo_vehiculo.PASSAGERS = pasajeros;
        nuevo_vehiculo.ENROLLMENT = matricula;
        nuevo_vehiculo.INSURANCE_NO = seguro.ToString();
        nuevo_vehiculo.PHOTO = foto;


        //GetPost2(API, nuevo_vehiculo);
    }

    //public async Task<string> Lanzar(Vehicle v)
    //{

    //    try
    //    {

    //        HttpClient client = new HttpClient()
    //        {
    //            BaseAddress = new Uri("https://pruebasv4.herokuapp.com/registervehicle"),
    //        };
    //        client.DefaultRequestHeaders.Accept.Clear();
    //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    //        HttpResponseMessage respuesta = client.PostAsJsonAsync("/registervehicle/", v).Result;
    //        if (respuesta.StatusCode == HttpStatusCode.OK)
    //        {
    //            // La respuesta es correcta y por ejemplo la retorno como string
    //            return await respuesta.Content.ReadAsStringAsync();
    //        }

    //    }
    //    catch (Exception e)
    //    {

    //    }

    //    return "OK";

    //}

    //public static string GetPost1(string url, Vehicle vehiculo)
    //{

    //    string result = "";


    //    WebRequest oRequest = WebRequest.Create(url);
    //    oRequest.Method = "post";
    //    oRequest.ContentType = "application/json; charset-UTF-8";

    //    using (var oSW = new StreamWriter(oRequest.GetRequestStream()))
    //    {

    //        string json = JsonConvert.SerializeObject(vehiculo, Formatting.Indented);

    //        oSW.Write(json);

    //        oSW.Flush();
    //        oSW.Close();

    //    }

    //    WebResponse oResponse = oRequest.GetResponse();
    //    using (var oSR = new StreamReader(oResponse.GetResponseStream()))
    //    {
    //        result = oSR.ReadToEnd().Trim();
    //    }


    //    return result;
    //}

    //public static string GetPost2(string url, Vehicle vehiculo)
    //{

    //    string result = "";


    //    WebRequest oRequest = WebRequest.Create(url);
    //    oRequest.Method = "post";
    //    oRequest.ContentType = "application/json; charset-UTF-8";

    //    using (var oSW = new StreamWriter(oRequest.GetRequestStream()))
    //    {

    //        string json = "{ \"BRAND\":\"Audi\", \"MODEL\":\"R8\", \"YEAR\":\"2015\", \"COLOUR\":\"Azul\", \"PRICEPERDAY\":\"5000\"}";

    //        oSW.Write(json);

    //        oSW.Flush();
    //        oSW.Close();

    //    }

    //    WebResponse oResponse = oRequest.GetResponse();
    //    using (var oSR = new StreamReader(oResponse.GetResponseStream()))
    //    {
    //        result = oSR.ReadToEnd().Trim();
    //    }


    //    return result;
    //}

    public async Task ApiRest()
    {
        var http = new HttpClient();

        var body = new
        {
            BRAND = marca,
            MODEL = modelo,
            YEAR = año,
            COLOUR = color,
            PRICEPERDAY = precio,
            TYPE = tipo,
            LOADCAPACITY = capacidad,
            PASSAGERS = pasajeros,
            ENROLLMENT = matricula,
            INSURANCE_NO = seguro,
            PHOTO = foto,

        };

        var jsonBody = JsonConvert.SerializeObject(body);
        var buffer = Encoding.UTF8.GetBytes(jsonBody);
        var byteContent = new ByteArrayContent(buffer);
        byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await http.PostAsync("https://pruebasv4.herokuapp.com/registervehicle", byteContent);
        // var response = await http.GetAsync("https://pruebasv4.herokuapp.com");

        var content = await response.Content.ReadAsStringAsync();

        Console.WriteLine(content);
    }

    public class Vehicle
    {

        public string BRAND { get; set; }

        public string MODEL { get; set; }

        public int YEAR { get; set; }

        public string COLOUR { get; set; }

        public int PRICEPERDAY { get; set; }

        public string TYPE { get; set; }

        public string LOADCAPACITY { get; set; }

        public int PASSAGERS { get; set; }

        public string ENROLLMENT { get; set; }

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
