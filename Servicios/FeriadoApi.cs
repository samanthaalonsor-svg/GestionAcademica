using System.Text.Json.Serialization;

namespace GestionAcademica.Servicios
{
   
    public class FeriadoApi
    {
        [JsonPropertyName("date")]
        public DateTime Fecha { get; set; }

        [JsonPropertyName("localName")]
        public string NombreLocal { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("countryCode")]
        public string CodigoPais { get; set; } = string.Empty;

        [JsonPropertyName("global")]
        public bool Global { get; set; }

        [JsonPropertyName("types")]
        public List<string> Tipos { get; set; } = new List<string>();
    }

   
    public class RespuestaFeriados
    {
        public List<FeriadoApi> Feriados { get; }
        public string JsonOriginal { get; }

        public RespuestaFeriados(List<FeriadoApi> feriados, string jsonOriginal)
        {
            Feriados = feriados;
            JsonOriginal = jsonOriginal;
        }
    }
}
