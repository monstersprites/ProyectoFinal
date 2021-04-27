using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class CedulaService
    {
        public async Task<DatosCedula> GetDatosAsync(string cedula)
        {
            var http = new HttpClient();

            return await http.GetFromJsonAsync<DatosCedula>($"https://api.adamix.net/apec/cedula/{cedula}");
        }
    }
}
