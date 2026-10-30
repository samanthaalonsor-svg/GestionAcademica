using System.Net;
using System.Net.Http.Headers;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace GestionAcademica.Servicios
{
    
    public class FeriadosApiClient
    {
        private const string UrlBase = "https://date.nager.at/api/v3/";

        
        private static readonly HttpClient cliente = CrearCliente();

        private static readonly JsonSerializerOptions opcionesLectura = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        private static readonly JsonSerializerOptions opcionesEscritura = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        private static HttpClient CrearCliente()
        {
            HttpClient http = new HttpClient
            {
                BaseAddress = new Uri(UrlBase),
                Timeout = TimeSpan.FromSeconds(15)
            };
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            http.DefaultRequestHeaders.UserAgent.ParseAdd("GestionAcademica/1.0");
            return http;
        }

        public async Task<RespuestaFeriados> ObtenerFeriadosAsync(
            string codigoPais, int anio, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(codigoPais))
                throw new InvalidOperationException("Debe seleccionar un país.");

            string ruta = $"PublicHolidays/{anio}/{codigoPais.Trim().ToUpperInvariant()}";

            try
            {
                using (HttpResponseMessage respuesta = await cliente.GetAsync(ruta, cancellationToken))
                {
                    if (respuesta.StatusCode == HttpStatusCode.NotFound ||
                        respuesta.StatusCode == HttpStatusCode.NoContent)
                    {
                        throw new InvalidOperationException(
                            $"El servicio no tiene feriados para el país {codigoPais} en {anio}. Pruebe con otro país o año.");
                    }

                    respuesta.EnsureSuccessStatusCode();

                    string json = await respuesta.Content.ReadAsStringAsync(cancellationToken);

                    List<FeriadoApi> feriados =
                        JsonSerializer.Deserialize<List<FeriadoApi>>(json, opcionesLectura)
                        ?? new List<FeriadoApi>();

                    return new RespuestaFeriados(
                        feriados.OrderBy(f => f.Fecha).ToList(),
                        DarFormato(json));
                }
            }
            catch (HttpRequestException ex)
            {
                throw new InvalidOperationException(
                    "No se pudo conectar con el servicio web. Verifique su conexión a Internet.\n" + ex.Message, ex);
            }
            catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                
                throw new InvalidOperationException("El servicio web tardó demasiado en responder (tiempo agotado).");
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException("La respuesta del servicio no tiene el formato JSON esperado.\n" + ex.Message, ex);
            }
        }

        private static string DarFormato(string json)
        {
            try
            {
                using (JsonDocument documento = JsonDocument.Parse(json))
                    return JsonSerializer.Serialize(documento.RootElement, opcionesEscritura);
            }
            catch (JsonException)
            {
                return json;
            }
        }
    }
}
