using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Encodings.Web;

namespace GestionAcademica.Servicios
{
   
    public sealed class ResendEmailApiClient
    {
        private static readonly HttpClient Http = new HttpClient
        {
            BaseAddress = new Uri("https://api.resend.com/"),
            Timeout = TimeSpan.FromSeconds(30)
        };

        public async Task<string> EnviarNotificacionAsync(
            string destinatario, string nombreEstudiante, string asunto, string mensaje,
            CancellationToken cancellationToken = default)
        {
            string apiKey = Environment.GetEnvironmentVariable("RESEND_API_KEY");
            string remitente = Environment.GetEnvironmentVariable("RESEND_FROM_EMAIL");

            if (string.IsNullOrWhiteSpace(apiKey))
                throw new InvalidOperationException(
                    "No está configurada la variable de entorno RESEND_API_KEY. Configure su clave API de Resend antes de enviar correos.");

            if (string.IsNullOrWhiteSpace(remitente))
                remitente = "onboarding@resend.dev";

            if (!EsCorreoValido(destinatario))
                throw new InvalidOperationException("Ingrese una dirección de correo válida para el destinatario.");

            if (!EsCorreoValido(remitente))
                throw new InvalidOperationException("La variable RESEND_FROM_EMAIL no contiene una dirección válida.");

            if (string.IsNullOrWhiteSpace(nombreEstudiante) || nombreEstudiante.Trim().Length > 120)
                throw new InvalidOperationException("Ingrese el nombre del estudiante (máximo 120 caracteres).");

            if (string.IsNullOrWhiteSpace(asunto) || asunto.Trim().Length > 180)
                throw new InvalidOperationException("El asunto es obligatorio y no debe superar 180 caracteres.");

            if (string.IsNullOrWhiteSpace(mensaje) || mensaje.Trim().Length > 5000)
                throw new InvalidOperationException("El mensaje es obligatorio y no debe superar 5000 caracteres.");

            string nombreSeguro = HtmlEncoder.Default.Encode(nombreEstudiante.Trim());
            string asuntoSeguro = HtmlEncoder.Default.Encode(asunto.Trim());
            string mensajeSeguro = HtmlEncoder.Default.Encode(mensaje.Trim())
                .Replace("\r\n", "\n").Replace("\n", "<br>");

            var payload = new
            {
                from = remitente,
                to = new[] { destinatario.Trim() },
                subject = asunto.Trim(),
                text = $"Estimado/a {nombreEstudiante.Trim()},\n\n{mensaje.Trim()}\n\nGestión Académica",
                html = $"<div style=\"font-family:Segoe UI,Arial,sans-serif;color:#1f2937;line-height:1.6\"><h2 style=\"color:#1b365d\">Gestión Académica</h2><p>Estimado/a <strong>{nombreSeguro}</strong>:</p><p>{mensajeSeguro}</p><hr><small>Notificación enviada desde el sistema de Gestión Académica.</small></div>"
            };

            using var request = new HttpRequestMessage(HttpMethod.Post, "emails");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            request.Headers.UserAgent.ParseAdd("GestionAcademica/1.0");
            request.Content = JsonContent.Create(payload);

            using HttpResponseMessage response = await Http.SendAsync(request, cancellationToken);
            string respuesta = await response.Content.ReadAsStringAsync(cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                string detalle = respuesta.Length > 700 ? respuesta[..700] : respuesta;
                throw new InvalidOperationException(
                    $"El servicio de correo respondió {(int)response.StatusCode} ({response.ReasonPhrase}). {detalle}");
            }

            try
            {
                using JsonDocument doc = JsonDocument.Parse(respuesta);
                if (doc.RootElement.TryGetProperty("id", out JsonElement id))
                    return id.GetString() ?? "Aceptado por el servicio";
            }
            catch (JsonException) { /* La respuesta fue exitosa aunque no se pudiera leer el identificador. */ }

            return "Aceptado por el servicio";
        }

        private static bool EsCorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo) || correo.Length > 254)
                return false;
            try
            {
                var direccion = new MailAddress(correo.Trim());
                return direccion.Address.Equals(correo.Trim(), StringComparison.OrdinalIgnoreCase);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
